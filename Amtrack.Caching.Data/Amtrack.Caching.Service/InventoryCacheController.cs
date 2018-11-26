using System;
using System.Collections.Generic;
using System.Linq;
using Amtrack.Caching.Data.StockCheckData;
using Amtrack.Caching.Repository;
using Amtrack.Enumeration;
using Amtrack.Extensions;
using Amtrack.StockCheck.Data.Data;
using Amtrack.ValueObjects.Branding;
using Amtrack.ValueObjects.Inventory;
using Amtrack.ValueObjects.OrderEntry;

namespace Amtrack.Caching.Service
{
	internal class InventoryCacheController
	{
		#region Private Variables
		private readonly ICachingRepository _cachingRepository;
		private readonly LazyLoaderController _lazyLoaderController;
		#endregion

		public InventoryCacheController(ICachingRepository cachingRepository,
			LazyLoaderController lazyLoaderController)
		{
			_cachingRepository = cachingRepository;
			_lazyLoaderController = lazyLoaderController;
		}

		#region Private Methods
		private InventoryPricingVO GetInventoryPricingVO(string itemCode)
		{
			return new InventoryPricingVO
			{
				ItemCode = itemCode,
				Prices = _lazyLoaderController.InventoryPricing.Value.GetValue(itemCode)?
				.Select(s => new InventoryPriceVO()
				{
					Price = s.Price,
					PriceList = _lazyLoaderController.StockPriceLists.Value.GetValue(s.PricelistId)?.ToPriceListVo()
				}).ToList() ?? new List<InventoryPriceVO>()
			};
		}

		private InventoryItemVO GetInventoryItemVO(string itemCode, bool setStockInfo)
		{
			var catalugueItem = _lazyLoaderController.CatalogueItems.Value.GetValue(itemCode);

			if(catalugueItem == null)
				return null;

			return GetInventoryItemVO(catalugueItem, setStockInfo);
		}

		private InventoryItemVO GetInventoryItemVO(stCatalogue catalugueItem, bool setStockInfo)
		{
			var stockItemGroup = _lazyLoaderController.StockItemGroups.Value.GetValue(catalugueItem.InventoryGroupId);

			var inventoryItemVO = catalugueItem.ToInventoryItemVo(stockItemGroup);

			if(!(inventoryItemVO.IsComponent || inventoryItemVO.IsSet))
				inventoryItemVO.Prices = GetInventoryPricingVO(catalugueItem.ItemCode);

			if(setStockInfo)
			{
				var inventorySetVO = GetInventorySetVO(catalugueItem.ItemCode);

				if(inventorySetVO != null)
					inventoryItemVO.SetInfo = inventorySetVO;
			}

			return inventoryItemVO;
		}

		private InventorySetVO GetInventorySetVO(string itemCode)
		{
			var stockSet = _lazyLoaderController.StockSets.Value
				.FirstOrDefault(w => w.ItemCode.Equals(itemCode, StringComparison.CurrentCultureIgnoreCase));

			if(stockSet == null)
				return null;

			return GetInventorySetVO(stockSet);
		}

		private InventorySetVO GetInventorySetVO(StockSets stockSet)
		{
			var voSet = new InventorySetVO
			{
				BaseItemCode = stockSet.BaseCode,
				ItemCode = stockSet.ItemCode,
				Colour = stockSet.Colour,
				Size = stockSet.Size,
				Description = stockSet.Description,
				InvoiceCode = stockSet.InvoiceCode,
				InvoiceDiscountProject = stockSet.InvoiceDiscountCode,
				Flags = (StockSetFlags)stockSet.Flags,
				Contents = new List<ValueObjects.Inventory.InventorySetContentVO>(),
				Components = new List<ValueObjects.Inventory.InventorySetComponentVO>(),
			};

			var lastSequence = stockSet.StockSetContents
				.OrderByDescending(c => c.Sequence)
				?.FirstOrDefault()
				?.Sequence;

			foreach(var item in stockSet.StockSetContents
				.OrderBy(c => c.ItemCode.Equals("CONSOLIDATE", StringComparison.CurrentCultureIgnoreCase) ? (lastSequence + 1) : c.Sequence))
			{
				voSet.Contents.Add(new InventorySetContentVO
				{
					BaseItemCode = item.BaseItemCode,
					ItemCode = item.ItemCode,
					Colour = item.Colour,
					Size = item.Size,
					Sequence = item.Sequence,
					Multiplier = item.Multiplier,
					Flags = (StockSetContentFlags)item.Flags
				});
			}

			var componentLastSequence = stockSet.StockSetComponents
				.OrderByDescending(c => c.Sequence)
				?.FirstOrDefault()
				?.Sequence;

			foreach(var component in stockSet.StockSetComponents
				.OrderBy(c => (c.AutoAdditionItemCode ?? "").Equals("CONSOLIDATE", StringComparison.CurrentCultureIgnoreCase) ? (componentLastSequence + 1) : c.Sequence))
			{
				var inventorySetComponentVO = new ValueObjects.Inventory.InventorySetComponentVO
				{
					BaseItemCode = component.BaseCode,
					Created = component.Created,
					Description = component.Description,
					Flags = (StockSetComponentFlags)component.Flags,
					Id = component.Id,
					Prefix = component.Prefix,
					Sequence = component.Sequence,
					AutoAdditionItemCode = component.AutoAdditionItemCode,
					InventoryItems = new List<ValueObjects.Inventory.InventoryItemVO>()
				};

				inventorySetComponentVO.InventoryItems = _lazyLoaderController.CatalogueItems
					.Value.Values
					.Where(w => w.BaseItemCode == component.BaseCode && w.ItemCode.ToLower().Contains(component.Prefix.ToLower()))
					.Select(s => GetInventoryItemVO(s, false))
					.ToList();

				voSet.Components.Add(inventorySetComponentVO);
			}

			return voSet;
		}

		private EmbroideryPricingVO GetEmbroideryPricingVO(StockEmbroideryPricing stockEmbroideryPricing)
		{
			return new EmbroideryPricingVO()
			{
				Id = stockEmbroideryPricing.Id,
				Price = Math.Round(stockEmbroideryPricing.Price, 2, MidpointRounding.AwayFromZero),
				PriceCode = stockEmbroideryPricing.PriceCode,
				PriceList = _lazyLoaderController.StockPriceLists.Value.GetValue(stockEmbroideryPricing.FkPriceListId)?.ToPriceListVo(),
				QuantityHigh = stockEmbroideryPricing.QuantityHigh,
				QuantityLow = stockEmbroideryPricing.QuantityLow
			};
		}
		#endregion

		#region Public Methods
		public List<InventoryItemVO> GetInventoryItemVOs()
		{
			var inventoryItemDVOs = _lazyLoaderController.CatalogueItems.Value
			.AsParallel()
			.Select(s =>
			{
				return GetInventoryItemVO(s.Value, true);
			})
			.Where(s => s.DefaultBrand != null)
			.ToDictionary(d => d.ItemCode, d => d);

			var setInventoryItemDVOs = _lazyLoaderController.StockSets.Value
			   .AsParallel()
			   .Where(w => (w.Flags & (int)StockSetFlags.VirtualItem) != 0
			  || (w.Flags & (int)StockSetFlags.MixedParts) != 0
			  || (w.Flags & (int)StockSetFlags.MixedComponents) != 0)
			  .Select(s => new InventoryItemVO
			  {
				  Id = -99,
				  BaseItemCode = s.BaseCode,
				  ItemCode = s.ItemCode,
				  ALPCategory = string.Empty,
				  Colour = s.Colour,
				  Size = s.Size,
				  DangerousGoods = false,
				  Description = s.Description,
				  HasSampleQuantityException = false,
				  HighValue = false,
				  InventoryType = InventoryType.Gift,
				  InvoiceVisible = true,
				  OnPromotion = false,
				  QuoteVisible = true,
				  WarehouseItem = true,
				  Flags = StockInventoryMasterFlags.Active,
				  Group = null,
				  SetInfo = GetInventorySetVO(s),
				  Brands = inventoryItemDVOs.ContainsKey(s.ItemCode)
				  ? inventoryItemDVOs[s.ItemCode]?.Brands
				  : inventoryItemDVOs.Values.FirstOrDefault(f => f.BaseItemCode == s.BaseCode)?.Brands
			  })
			  .Where(s => s.DefaultBrand != null)
			  .ToDictionary(d => d.ItemCode, d => d);

			var iventoryItemVOs = inventoryItemDVOs
				.Where(w => !setInventoryItemDVOs.ContainsKey(w.Key))
				.Select(s => s.Value)
				.ToList();

			return iventoryItemVOs;
		}

		public List<GroupVO> GetGroupVOs()
		{
			return _lazyLoaderController.StockItemGroups.Value.Values
				.Select(s => s.ToGroupVo())
				.ToList();
		}

		public List<InventoryPricingVO> GetInventoryPricingVOs()
		{
			return _lazyLoaderController.CatalogueItems.Value
			  .AsParallel()
			  .Select(s =>
			  {
				  return GetInventoryPricingVO(s.Key);
			  })
			  .ToList();
		}

		public List<PriceListVO> GetPriceListVOs()
		{
			return _lazyLoaderController.StockPriceLists.Value.Values
				.Select(s => s.ToPriceListVo())
				.ToList();
		}

		public List<InventorySetVO> GetInventorySetVOs()
		{
			return _lazyLoaderController.StockSets.Value
				.Select(s => GetInventorySetVO(s))
				.ToList();
		}

		public List<EmbroideryPricingVO> GetEmbroideryPricingVOs()
		{
			return _lazyLoaderController.StockEmbroideryPricing.Value
				.Select(s => GetEmbroideryPricingVO(s))
				.ToList();
		}
		#endregion

		public static InventoryCacheController Instance(ICachingRepository cachingRepository, LazyLoaderController lazyLoaderController)
		=> new InventoryCacheController(cachingRepository, lazyLoaderController);
	}
}
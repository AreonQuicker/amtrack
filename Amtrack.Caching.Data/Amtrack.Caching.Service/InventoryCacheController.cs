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
		private class CacheDictionary<TKey, TValue> : Dictionary<TKey, TValue>
		{
			public CacheDictionary()
				: base()
			{

			}

			public TValue GetValue(TKey key)
			{
				if(ContainsKey(key))
					return this[key];

				return default(TValue);
			}

			public static CacheDictionary<TKey, TValue> CreateDictionary(IEnumerable<TValue> values, Func<TValue, TKey> getKey, Func<TValue, TValue> getValue)
			{
				var cacheDictionary = new CacheDictionary<TKey, TValue>();

				foreach(var value in values)
				{
					var key = getKey(value);
					if(!cacheDictionary.ContainsKey(key))
						cacheDictionary.Add(key, getValue(value));
				}

				return cacheDictionary;
			}

			public static CacheDictionary<TKey, TValue> CreateDictionary(Dictionary<TKey, TValue> keyValuePairs)
			{
				var cacheDictionary = new CacheDictionary<TKey, TValue>();

				foreach(var keyValuePair in keyValuePairs)
					cacheDictionary.Add(keyValuePair.Key, keyValuePair.Value);

				return cacheDictionary;
			}
		}

		#region Private Variables
		private readonly ICachingRepository _cachingRepository;
		#endregion

		#region Lazy Variables
		private Lazy<CacheDictionary<string, stCatalogue>> _catalogueItems = null;

		private Lazy<CacheDictionary<string, List<stInventoryPricing>>> _inventoryPricing = null;

		private Lazy<CacheDictionary<int, StockItemGroups>> _stockItemGroups = null;

		private Lazy<CacheDictionary<int, StockPricelists>> _StockPriceLists = null;

		private Lazy<IEnumerable<StockSets>> _StockSets = null;

		private Lazy<IEnumerable<StockEmbroideryPricing>> _stockEmbroideryPricing = null;
		#endregion

		public InventoryCacheController(ICachingRepository cachingRepository)
		{
			this._cachingRepository = cachingRepository;

			_StockPriceLists = new Lazy<CacheDictionary<int, StockPricelists>>(() =>
			{
				return CacheDictionary<int, StockPricelists>
				.CreateDictionary(cachingRepository.GetAllStockPriceLists(), (v) => v.Id, (v) => v);

			});

			_stockItemGroups = new Lazy<CacheDictionary<int, StockItemGroups>>(() =>

			 {
				 return CacheDictionary<int, StockItemGroups>
			   .CreateDictionary(cachingRepository.GetAllStockItemGroups(), (v) => v.Id, (v) => v);

			 });

			_catalogueItems = new Lazy<CacheDictionary<string, stCatalogue>>(() =>
			 {

				 return CacheDictionary<string, stCatalogue>
			 .CreateDictionary(cachingRepository.stLoadCatalogue(), (v) => v.ItemCode, (v) => v);

			 });

			_inventoryPricing = new Lazy<CacheDictionary<string, List<stInventoryPricing>>>(() =>
			{
				var inventoryPricings = cachingRepository.stGetInventoryPricing();

				var values =
				inventoryPricings
				.GroupBy(g => new { g.ItemCode })
				.ToDictionary(d => d.Key.ItemCode, d => d.ToList());

				return CacheDictionary<string, List<stInventoryPricing>>.CreateDictionary(values);

			});

			_StockSets = new Lazy<IEnumerable<StockSets>>(() =>
			{
				return cachingRepository.GetAllStockSets()
				.Where(w => (w.Flags & (int)StockSetFlags.Disabled) == 0)
				.ToList();
			});


			_stockEmbroideryPricing = new Lazy<IEnumerable<StockEmbroideryPricing>>(() => cachingRepository.GetAllStockEmbroideryPricing());
		}

		#region Private Methods
		private InventoryPricingVO GetInventoryPricingVO(string itemCode)
		{
			return new InventoryPricingVO
			{
				ItemCode = itemCode,
				Prices = _inventoryPricing.Value.GetValue(itemCode)?
				.Select(s => new InventoryPriceVO()
				{
					Price = s.Price,
					PriceList = _StockPriceLists.Value.GetValue(s.PricelistId)?.ToPriceListVo()
				}).ToList() ?? new List<InventoryPriceVO>()
			};
		}

		private InventoryItemVO GetInventoryItemVO(string itemCode, bool setStockInfo)
		{
			var catalugueItem = _catalogueItems.Value.GetValue(itemCode);

			if(catalugueItem == null)
				return null;

			return GetInventoryItemVO(catalugueItem, setStockInfo);
		}

		private InventoryItemVO GetInventoryItemVO(stCatalogue catalugueItem, bool setStockInfo)
		{
			var stockItemGroup = _stockItemGroups.Value.GetValue(catalugueItem.InventoryGroupId);

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
			var stockSet = _StockSets.Value
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

				inventorySetComponentVO.InventoryItems = _catalogueItems
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
				PriceList = _StockPriceLists.Value.GetValue(stockEmbroideryPricing.FkPriceListId)?.ToPriceListVo(),
				QuantityHigh = stockEmbroideryPricing.QuantityHigh,
				QuantityLow = stockEmbroideryPricing.QuantityLow
			};
		}
		#endregion

		#region Public Methods
		public List<InventoryItemVO> GetInventoryItemVOs()
		{
			//TODO
			return _catalogueItems.Value
				.AsParallel()
				.Select(s =>
				{
					return GetInventoryItemVO(s.Value, true);
				})
				//.Where(s => s.DefaultBrand != null)
				.ToList();
		}

		public List<InventoryItemVO> GetInventoryStockSetItemVOs()
		{
			return _StockSets.Value
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
				   SetInfo = GetInventorySetVO(s)
			   })
			   .ToList();
		}

		public List<GroupVO> GetGroupVOs()
		{
			return _stockItemGroups.Value.Values
				.Select(s => s.ToGroupVo())
				.ToList();
		}

		public List<InventoryPricingVO> GetInventoryPricingVOs()
		{
			return _catalogueItems.Value
			  .AsParallel()
			  .Select(s =>
			  {
				  return GetInventoryPricingVO(s.Key);
			  })
			  .ToList();
		}

		public List<PriceListVO> GetPriceListVOs()
		{
			return _StockPriceLists.Value.Values
				.Select(s => s.ToPriceListVo())
				.ToList();
		}

		public List<InventorySetVO> GetInventorySetVOs()
		{
			return _StockSets.Value
				.Select(s => GetInventorySetVO(s))
				.ToList();
		}

		public List<EmbroideryPricingVO> GetEmbroideryPricingVOs()
		{
			return _stockEmbroideryPricing.Value
				.Select(s => GetEmbroideryPricingVO(s))
				.ToList();
		}
		#endregion

		public static InventoryCacheController Instance(ICachingRepository cachingRepository)
		=> new InventoryCacheController(cachingRepository);
	}
}
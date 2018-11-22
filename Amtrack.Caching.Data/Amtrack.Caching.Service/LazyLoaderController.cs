using System;
using System.Collections.Generic;
using System.Linq;
using Amtrack.Caching.Data.StockCheckData;
using Amtrack.Caching.Repository;
using Amtrack.Enumeration;
using Amtrack.StockCheck.Data.Data;

namespace Amtrack.Caching.Service
{
	internal class LazyLoaderController
	{
		private readonly ICachingRepository _cachingRepository;

		#region Lazy Variables
		public Lazy<CacheDictionary<string, stCatalogue>> CatalogueItems { get; }

		public Lazy<CacheDictionary<string, List<stInventoryPricing>>> InventoryPricing { get; }

		public Lazy<CacheDictionary<int, StockItemGroups>> StockItemGroups { get; }

		public Lazy<CacheDictionary<int, StockPricelists>> StockPriceLists { get; }

		public Lazy<IEnumerable<StockSets>> StockSets { get; }

		public Lazy<IEnumerable<StockEmbroideryPricing>> StockEmbroideryPricing { get; }
		#endregion

		public LazyLoaderController(ICachingRepository cachingRepository)
		{
			StockPriceLists = new Lazy<CacheDictionary<int, StockPricelists>>(() =>
			{
				return CacheDictionary<int, StockPricelists>
				.CreateDictionary(cachingRepository.GetAllStockPriceLists(), (v) => v.Id, (v) => v);

			});

			StockItemGroups = new Lazy<CacheDictionary<int, StockItemGroups>>(() =>

			{
				return CacheDictionary<int, StockItemGroups>
			  .CreateDictionary(cachingRepository.GetAllStockItemGroups(), (v) => v.Id, (v) => v);

			});

			CatalogueItems = new Lazy<CacheDictionary<string, stCatalogue>>(() =>
			{

				return CacheDictionary<string, stCatalogue>
				.CreateDictionary(cachingRepository.stLoadCatalogue(), (v) => v.ItemCode, (v) => v);

			});

			InventoryPricing = new Lazy<CacheDictionary<string, List<stInventoryPricing>>>(() =>
			{
				var inventoryPricings = cachingRepository.stGetInventoryPricing();

				var values =
				inventoryPricings
				.GroupBy(g => new { g.ItemCode })
				.ToDictionary(d => d.Key.ItemCode, d => d.ToList());

				return CacheDictionary<string, List<stInventoryPricing>>.CreateDictionary(values);

			});

			StockSets = new Lazy<IEnumerable<StockSets>>(() =>
			{
				return cachingRepository.GetAllStockSets()
				.Where(w => (w.Flags & (int)StockSetFlags.Disabled) == 0)
				.ToList();
			});

			StockEmbroideryPricing = new Lazy<IEnumerable<StockEmbroideryPricing>>(() => cachingRepository.GetAllStockEmbroideryPricing());

			_cachingRepository = cachingRepository;
		}
	}
}
﻿using System;
using System.Linq;
using System.Threading;
using Amtrack.Cache.Store;
using Amtrack.Caching.Service;
using Amtrack.DependencyInjection;
using Amtrack.Logger;
using Amtrack.ValueObjects.Branding;
using Amtrack.ValueObjects.Inventory;
using Amtrack.ValueObjects.OrderEntry;

namespace Amtrack.Background.Cache.Service.AsyncCacheServices
{
	public class AsyncInventoryCacheService : BaseAsyncCacheService
	{
		public AsyncInventoryCacheService(
		   ICacheStore cacheStore,
		   IAmtrackLogger logger,
		   bool synchronous,
		   string serviceName)
			: base(cacheStore, logger, synchronous, serviceName)
		{

		}

		public override bool SetData(CancellationToken cancellationToken)
		{
			logger.LogInfo($"Saving Cache For Service {ServiceName} On Method {"GetInventoryCacheModel"} - Start");

			var cachingService = DependencyInjector.Retrieve<ICachingService>();

			var inventoryCacheModel = cachingService.GetInventoryCacheModel();

			if(inventoryCacheModel == null)
				throw new NullReferenceException(nameof(inventoryCacheModel));

			var inventoryItemValues = inventoryCacheModel.InventoryItems
				.ToDictionary(d => d.CacheKey, d => d);

			cacheStore.SetAll<InventoryItemVO>(inventoryItemValues, new string[] { "BaseItemCode", "ItemCode", "Colour" });
			cacheStore.SetAll(inventoryCacheModel.Groups);
			cacheStore.SetAll(inventoryCacheModel.InventoryPricing);
			cacheStore.SetAll(inventoryCacheModel.InventorySets);
			cacheStore.SetAll(inventoryCacheModel.PriceLists);
			cacheStore.SetAll(inventoryCacheModel.EmbroideryPricing);

			logger.LogInfo($"Saving Cache For Service {ServiceName} On Method {"GetInventoryCacheModel"} - Complete");

			return true;
		}

		public override bool DeleteData(CancellationToken cancellationToken)
		{
			logger.LogInfo($"Deleting Cache For Service {ServiceName} On Method {"GetInventoryCacheModel"} - Start");

			cacheStore.DeleteAll<PriceListVO>();
			cacheStore.DeleteAll<GroupVO>();
			cacheStore.DeleteAll<InventoryItemVO>();
			cacheStore.DeleteAll<InventoryPricingVO>();
			cacheStore.DeleteAll<InventorySetVO>();
			cacheStore.DeleteAll<EmbroideryPricingVO>();

			logger.LogInfo($"Deleting Cache For Service {ServiceName} On Method {"GetInventoryCacheModel"} - Complete");

			return true;
		}
	}
}

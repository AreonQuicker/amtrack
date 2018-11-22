﻿using System;
using System.Collections.Generic;
using Amtrack.Cache.SDK;
using Amtrack.Cache.Store;
using Amtrack.ValueObjects.Inventory;

namespace Amtrack.Cache.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			var configurations = new Dictionary<ConfigurationType, object>()
			{
				[ConfigurationType.AppKey] = "Amtrack.Cache",
				[ConfigurationType.DefaultCacheTimeSpan] = new TimeSpan(0, 10, 0),
				[ConfigurationType.DefaultInternalCacheTimeSpan] = new TimeSpan(0, 0, 20),
				[ConfigurationType.Host] = "127.0.0.1:6379"
			};

			ICacheSDK cacheSDK = new CacheSDK(configurations, true, false);

			var NOnitem = cacheSDK.Get<InventoryItemVO>("BAG-30dsda00");

			var item = cacheSDK.Get<InventoryItemVO>("BAG-3000");

			var item2 = cacheSDK.Get<InventoryItemVO>("BAG-3000");

			var items = cacheSDK.GetAll<InventoryItemVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "BaseItemCode",
				Value = "BAG-612"
			}, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "Colour",
				Value = "BL"
			});

			var items2 = cacheSDK.GetAll<InventoryItemVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "BaseItemCode",
				Value = "BAG-612"
			}, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "Colour",
				Value = "BL"
			});

			var items3 = cacheSDK.GetAll<InventoryItemVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "BaseItemCode",
				Value = "BAG-612fdsadas"
			}, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "Colour",
				Value = "BLfdas"
			});

			var items4 = cacheSDK.GetAll<InventoryItemVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "fdfsd",
				Value = "BAG-612fdsadas"
			});

		}
	}
}

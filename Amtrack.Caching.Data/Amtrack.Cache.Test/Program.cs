using System;
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
				[ConfigurationType.Host] = "redisserver"
			};

			ICacheSDK cacheSDK = new CacheSDK(configurations, true, true);

			var NOnitem = cacheSDK.Get<InventoryItemVO>("BAG-30dsda00");

			var item = cacheSDK.Get<InventoryItemVO>("BAG-3000");

			var item2 = cacheSDK.Get<InventoryItemVO>("BAG-3000");

			var items = cacheSDK.GetAll<InventoryItemVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "BaseItemCode",
				Value = "BAG-612"
			});

			var items2 = cacheSDK.GetAll<InventoryItemVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "BaseItemCode",
				Value = "BAG-612"
			});

			var items3 = cacheSDK.GetAll<InventoryItemVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "BaseItemCode",
				Value = "BAG-612fdsadas"
			});

			var items4 = cacheSDK.GetAll<InventoryItemVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "fdfsd",
				Value = "BAG-612fdsadas"
			});

			var accounts1 = cacheSDK.GetAll<ValueObjects.Accounts.AccountMasterVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "CustomerCode",
				Value = "A"
			});

			var accounts = cacheSDK.GetAll<ValueObjects.Accounts.AccountMasterVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "CustomerCode",
				Value = "B"
			});

			var accounts3 = cacheSDK.GetAll<ValueObjects.Accounts.AccountMasterVO>(ConnectionType.And, new ConnectionValue
			{
				ConnectionValueType = ConnectionValueType.StartsWith,
				Field = "CustomerCode",
				Value = "P"
			});

			var allAccounts = cacheSDK.GetAllMultiple<ValueObjects.Accounts.AccountMasterVO>();

		}
	}
}

﻿using System.Collections.Generic;
using System.Linq;
using Amtrack.Caching.Repository;
using Amtrack.Extensions;
using Amtrack.Models.Cache;
using Amtrack.ValueObjects.Inventory;
using Amtrack.ValueObjects.OrderEntry;

namespace Amtrack.Caching.Service
{
	public class CachingService : BaseCachingService, ICachingService
	{
		private readonly LazyLoaderController lazyLoaderController;

		public CachingService(ICachingRepository cachingRepository)
			: base(cachingRepository)
		{
			lazyLoaderController = new LazyLoaderController(cachingRepository);
		}

		public UserCacheModel GetUserCacheModel()
		{
			return new UserCacheModel
			{
				SecurityLevels = cachingRepository.GetAllPermissions()
				.Select(s => s.ToSecurityLevelVo())
				.ToList(),

				Users = cachingRepository.GetAllUsersWithParents()
				.Select(s => s.ToUserVo())
				.ToList()
			};
		}

		public InventoryCacheModel GetInventoryCacheModel()
		{
			var inventoryCacheModel = new InventoryCacheModel
			{
				Groups = new List<GroupVO>(),
				InventoryItems = new List<InventoryItemVO>(),
				InventoryPricing = new List<InventoryPricingVO>(),
				PriceLists = new List<PriceListVO>(),
				InventorySets = new List<InventorySetVO>(),
				EmbroideryPricing = new List<ValueObjects.Branding.EmbroideryPricingVO>()
			};

			var inventoryCacheController = InventoryCacheController.Instance(cachingRepository, lazyLoaderController);

			inventoryCacheModel.Groups = inventoryCacheController.GetGroupVOs();
			inventoryCacheModel.PriceLists = inventoryCacheController.GetPriceListVOs();
			inventoryCacheModel.EmbroideryPricing = inventoryCacheController.GetEmbroideryPricingVOs();
			inventoryCacheModel.InventoryPricing = inventoryCacheController.GetInventoryPricingVOs();
			inventoryCacheModel.InventoryItems = inventoryCacheController.GetInventoryItemVOs();
			inventoryCacheModel.InventorySets = inventoryCacheController.GetInventorySetVOs();

			return inventoryCacheModel;
		}

		public AccountCacheModel GetAccountCacheModel()
		{
			var accountCacheModel = new AccountCacheModel
			{
				Accounts = new List<ValueObjects.Accounts.AccountMasterVO>(),
				TaxRates = new List<ValueObjects.Accounts.TaxRateVO>()
			};

			var accountCacheController = AccountCacheController.Instance(cachingRepository, lazyLoaderController);

			accountCacheModel.TaxRates = accountCacheController.GetTaxRateVOs();
			accountCacheModel.Accounts = accountCacheController.GetAccountsVOs();

			return accountCacheModel;
		}
	}
}

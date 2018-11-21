using System.Collections.Generic;
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

		public CachingService(ICachingRepository cachingRepository)
			: base(cachingRepository)
		{

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

			var inventoryCacheController = InventoryCacheController.Instance(cachingRepository);

			inventoryCacheModel.Groups = inventoryCacheController.GetGroupVOs();
			inventoryCacheModel.PriceLists = inventoryCacheController.GetPriceListVOs();
			inventoryCacheModel.EmbroideryPricing = inventoryCacheController.GetEmbroideryPricingVOs();
			inventoryCacheModel.InventoryPricing = inventoryCacheController.GetInventoryPricingVOs();
			inventoryCacheModel.InventoryItems = inventoryCacheController.GetInventoryItemVOs();
			//inventoryCacheModel.InventoryItems.AddRange(inventoryCacheController.GetInventoryStockSetItemVOs());
			inventoryCacheModel.InventorySets = inventoryCacheController.GetInventorySetVOs();

			return inventoryCacheModel;
		}
	}
}

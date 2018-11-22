using Amtrack.Models.Cache;

namespace Amtrack.Caching.Service
{
	public interface ICachingService
	{
		UserCacheModel GetUserCacheModel();
		InventoryCacheModel GetInventoryCacheModel();
		AccountCacheModel GetAccountCacheModel();
	}
}

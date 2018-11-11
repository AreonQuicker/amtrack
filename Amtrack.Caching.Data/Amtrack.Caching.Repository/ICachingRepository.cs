using System.Collections.Generic;
using Amtrack.Amtrack.Data.Data;
using Amtrack.Amtrack_V2.Data.Data;
using Amtrack.Caching.Data.StockCheckData;
using Amtrack.Core.Repositories;
using Amtrack.StockCheck.Data.Data;

namespace Amtrack.Caching.Repository
{
	public interface ICachingRepository : ICoreRepository
	{
		IEnumerable<User> GetAllUsersV1();
		IEnumerable<Users> GetAllUsers();
		IEnumerable<Users> GetAllUsersWithParents();
		IEnumerable<Permission> GetAllPermissions();
		IEnumerable<StockPricelists> GetStockPriceLists();
		IEnumerable<StockItemGroups> GetStockItemGroups();
		IEnumerable<stCatalogue> stLoadCatalogue();
	}
}

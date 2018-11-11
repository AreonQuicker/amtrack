using System.Collections.Generic;
using Amtrack.ValueObjects.Inventory;
using Amtrack.ValueObjects.OrderEntry;
using Amtrack.ValueObjects.Security;
using Amtrack.ValueObjects.Users;

namespace Amtrack.Caching.Service
{
	public interface ICachingService
	{
		IEnumerable<SecurityLevelVO> GetSecurityLevelsVo();
		IEnumerable<UserVO> GetUsersVo();
		IEnumerable<PriceListVO> GetPriceListVos();
		IEnumerable<InventoryItemVO> GetInventoryItemVos();
	}
}

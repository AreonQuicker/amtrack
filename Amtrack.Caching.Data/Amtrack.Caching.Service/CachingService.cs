using System.Collections.Generic;
using System.Linq;
using Amtrack.Caching.Repository;
using Amtrack.Core.Services;
using Amtrack.Extensions;
using Amtrack.ValueObjects.Inventory;
using Amtrack.ValueObjects.OrderEntry;
using Amtrack.ValueObjects.Security;
using Amtrack.ValueObjects.Users;

namespace Amtrack.Caching.Service
{
	public class CachingService : CoreBaseService, ICachingService
	{
		private readonly ICachingRepository _cachingRepository;

		public CachingService(ICachingRepository cachingRepository)
		{
			_cachingRepository = cachingRepository;
		}

		public IEnumerable<SecurityLevelVO> GetSecurityLevelsVo()
		{
			return _cachingRepository.GetAllPermissions().Select(s => s.ToSecurityLevelVo()).ToList();
		}

		public IEnumerable<UserVO> GetUsersVo()
		{
			return _cachingRepository.GetAllUsersWithParents().Select(s => s.ToUserVo()).ToList();
		}

		public IEnumerable<PriceListVO> GetPriceListVos()
		{
			throw new System.NotImplementedException();
		}

		/// <inheritdoc />
		public IEnumerable<InventoryItemVO> GetInventoryItemVos()
		{
			var Catalogue = _cachingRepository.stLoadCatalogue();



		}
	}
}

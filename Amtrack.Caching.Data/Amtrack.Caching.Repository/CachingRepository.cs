using System.Collections.Generic;
using System.Linq;
using Amtrack.Amtrack.Data;
using Amtrack.Amtrack.Data.Data;
using Amtrack.Amtrack_V2.Data;
using Amtrack.Amtrack_V2.Data.Data;
using Amtrack.Caching.Data;
using Amtrack.Caching.Data.StockCheckData;
using Amtrack.Core.Repositories;
using Amtrack.StockCheck.Data;
using Amtrack.StockCheck.Data.Data;
using Microsoft.EntityFrameworkCore;

namespace Amtrack.Caching.Repository
{
	public class CachingRepository : CoreBaseRepository, ICachingRepository
	{
		private readonly AmtrackStockCheckCachingContext _amtrackStockCheckCachingContext;

		public CachingRepository(AmtrackV2Context amtrackV2Context,
			AmtrackContext amtrackContext,
			AmtrackStockCheckContext amtrackStockCheckContext,
			AmtrackStockCheckCachingContext amtrackStockCheckCachingContext)
			: base(amtrackV2Context, amtrackContext, amtrackStockCheckContext)
		{
			_amtrackStockCheckCachingContext = amtrackStockCheckCachingContext;
		}

		public IEnumerable<Users> GetAllUsers()
		{
			return AmtrackV2Context.Users.ToList();
		}

		/// <inheritdoc />
		public IEnumerable<Users> GetAllUsersWithParents()
		{
			return AmtrackV2Context.Users.Include(i => i.UserUser).ToList();
		}

		/// <inheritdoc />
		public IEnumerable<Permission> GetAllPermissions()
		{
			return AmtrackContext.Permission.ToList();
		}

		/// <inheritdoc />
		public IEnumerable<StockPricelists> GetStockPriceLists()
		{
			throw new System.NotImplementedException();
		}

		/// <inheritdoc />
		public IEnumerable<StockItemGroups> GetStockItemGroups()
		{
			throw new System.NotImplementedException();
		}

		/// <inheritdoc />
		public IEnumerable<stCatalogue> stLoadCatalogue()
		{
			var stCatalogue = _amtrackStockCheckCachingContext.stCatalogue.FromSql("EXEC stLoadCatalogue").ToList();

			return stCatalogue;
		}

		public IEnumerable<User> GetAllUsersV1()
		{
			return AmtrackContext.User.ToList();
		}
	}
}

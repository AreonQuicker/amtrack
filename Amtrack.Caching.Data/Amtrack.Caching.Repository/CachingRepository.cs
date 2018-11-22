using System;
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
	public class CachingRepository : CoreBaseRepository, ICachingRepository, IDisposable
	{
		private readonly AmtrackStockCheckCachingContext _amtrackStockCheckCachingContext;

		#region Public Methods
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
		public IEnumerable<StockPricelists> GetAllStockPriceLists()
		{
			return AmtrackStockCheckContext.StockPricelists.ToList();
		}

		/// <inheritdoc />
		public IEnumerable<StockItemGroups> GetAllStockItemGroups()
		{
			return AmtrackStockCheckContext.StockItemGroups.ToList();
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

		public StockItemGroups GetStockItemGroups(int id)
		{
			return AmtrackStockCheckContext.StockItemGroups
				.FirstOrDefault(f => f.Id == id);

		}

		public IEnumerable<StockItemGroups> GetStockItemGroups()
		{
			return AmtrackStockCheckContext.StockItemGroups
				 .ToList();
		}

		public StockItemGroups GetStockItemGroup(int id)
		{
			return AmtrackStockCheckContext.StockItemGroups
				.FirstOrDefault(f => f.Id == id);
		}

		public IEnumerable<stInventoryPricing> stGetInventoryPricing()
		{
			var stInventoryPricings = _amtrackStockCheckCachingContext.stInventoryPricings.FromSql("EXEC stGetInventoryPricing").ToList();

			return stInventoryPricings;
		}

		public StockPricelists GetStockPricelist(int id)
		{
			return AmtrackStockCheckContext.StockPricelists
			  .FirstOrDefault(f => f.Id == id);
		}

		public IEnumerable<StockSets> GetAllStockSets()
		{
			return AmtrackStockCheckContext.StockSets
			 .Include(i => i.StockSetComponents)
			 .Include(i => i.StockSetContents)
			 .ToList();
		}

		public IEnumerable<StockEmbroideryPricing> GetAllStockEmbroideryPricing()
		{
			return AmtrackStockCheckContext.StockEmbroideryPricing
				.ToList();
		}

		public IEnumerable<TaxRates> GetAllTaxRates()
		{
			return AmtrackV2Context.TaxRates
				.ToList();
		}

		public IEnumerable<Accounts> GetAllAccounts(params string[] includes)
		{
			IQueryable<Accounts> accounts = AmtrackV2Context.Accounts;

			foreach(string s in includes)
				accounts = accounts.Include(s);

			return accounts
				.ToList();
		}
		#endregion

		public override void Dispose()
		{
			if(_amtrackStockCheckCachingContext != null)
			{
				_amtrackStockCheckCachingContext.Dispose();
			}

			base.Dispose();
		}

	}
}

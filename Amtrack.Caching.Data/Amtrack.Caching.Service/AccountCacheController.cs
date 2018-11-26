using System.Collections.Generic;
using System.Linq;
using Amtrack.Caching.Repository;
using Amtrack.Extensions;
using Amtrack.ValueObjects.Accounts;

namespace Amtrack.Caching.Service
{
	internal class AccountCacheController
	{
		#region Private Variables
		private readonly ICachingRepository _cachingRepository;
		private readonly LazyLoaderController lazyLoaderController;
		#endregion

		#region Lazy Variables
		#endregion

		public AccountCacheController(ICachingRepository cachingRepository, LazyLoaderController lazyLoaderController)
		{
			_cachingRepository = cachingRepository;
			this.lazyLoaderController = lazyLoaderController;
		}

		#region Private Methods
		#endregion

		#region Public Methods
		public List<TaxRateVO> GetTaxRateVOs()
		{
			return _cachingRepository.GetAllTaxRates()
				.Select(s => new TaxRateVO
				{
					CompanyCode = s.CompanyCode,
					DateCreated = s.Created,
					DateLastModified = s.Modified,
					Id = s.Id,
					PastelLookup = s.PastelLookup,
					Rate = s.Rate,
					Flags = (Enumeration.TaxRateFlags)s.Flags,
					HostId = s.XfxHostId
				})
				.ToList();
		}

		public List<AccountMasterVO> GetAccountsVOs()
		{
			var accounts = _cachingRepository.GetAllAccounts("TaxRate", "AccountAccountManagers", "MasterAccount");

			return accounts
				.Select(s =>
				{
					var masterAccount = s.MasterAccount;
					var masterAccountPriceList = masterAccount != null
					? lazyLoaderController.StockPriceLists.Value[s.MasterAccount.FkPricelistId]
					: null;

					return s.ToAccountMasterVO(lazyLoaderController.StockPriceLists.Value[s.FkPricelistId], masterAccount
					 , masterAccountPriceList);
				}
				)
				.ToList();
		}
		#endregion

		public static AccountCacheController Instance(ICachingRepository cachingRepository, LazyLoaderController lazyLoaderController)
		=> new AccountCacheController(cachingRepository, lazyLoaderController);
	}
}
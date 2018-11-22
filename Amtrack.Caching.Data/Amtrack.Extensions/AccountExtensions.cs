using System.Linq;
using Amtrack.Amtrack_V2.Data.Data;
using Amtrack.Enumeration;
using Amtrack.StockCheck.Data.Data;
using Amtrack.ValueObjects.Accounts;
using Amtrack.ValueObjects.Users;

namespace Amtrack.Extensions
{
	public static class AccountExtensions
	{

		public static AccountAccountManagerVO ToAccountAccountManagerVO(this AccountAccountManagers accountManager, UserVO userVO = null)
		{
			if(userVO == null)
				userVO = accountManager.User.ToUserVo();

			return new ValueObjects.Accounts.AccountAccountManagerVO
			{
				AccountManager = userVO,
				Brand = accountManager.Brand,
				BrandId = accountManager.FkBrandId,
				Flags = (AccountAccountManagerFlags)accountManager.Flags
			};
		}

		public static ValueObjects.Accounts.AccountMasterVO ToAccountMasterVO(this Accounts account, StockPricelists dbPricelist)
		{
			var accountAccountManagers = account.AccountAccountManagers;

			var voAccount = new AccountMasterVO
			{
				Id = account.Id,
				DateCreated = account.Created,
				DateLastModified = account.Modified,
				//AccountFacilitator = dbAccount.Facilitator(),
				//AreaCode = dbAccount.AreaCode(),
				BranchCode = account.BranchCode,
				CompanyCode = account.CompanyCode,
				CustomerCode = account.Number,
				//DefNumber = dbAccount.DefNumber(),
				Name = account.Name,
				PaymentType = (Enumeration.AccountPaymentType)account.PaymentType,
				PrimaryEmailAddresses = account.Email?.Split(',', ';', ' '),
				//RegestrationNumber = dbAccount.RegistrationNumber(),
				Flags = (Enumeration.AccountFlags)account.Flags,
				//TaxNumber = dbAccount.VatNumber(),
				WebUrl = account.WebAddress,
				AccountAccountManagers = accountAccountManagers.Select(s => s.ToAccountAccountManagerVO()).ToList()
			};

			voAccount.TaxRate = new TaxRateVO
			{
				CompanyCode = account.TaxRate.CompanyCode,
				DateCreated = account.TaxRate.Created,
				DateLastModified = account.TaxRate.Modified,
				Id = account.TaxRate.Id,
				PastelLookup = account.TaxRate.PastelLookup,
				Rate = account.TaxRate.Rate,
				Flags = (Enumeration.TaxRateFlags)account.TaxRate.Flags,
				HostId = account.TaxRate.XfxHostId
			};

			voAccount.PriceList = new ValueObjects.OrderEntry.PriceListVO
			{
				CompanyCode = dbPricelist.CompanyCode,
				CurrencyCode = dbPricelist.CurrencyCode,
				CurrencyName = dbPricelist.CurrencyName,
				CurrencySymbol = dbPricelist.CurrencySymbol,
				DateCreated = dbPricelist.Created,
				DateLastModified = dbPricelist.Modified ?? dbPricelist.Created,
				DisplayIndex = dbPricelist.DisplayIndex,
				DisplayName = dbPricelist.DisplayName,
				HostId = dbPricelist.XfxHostId,
				Id = dbPricelist.Id,
				PastelLookup = dbPricelist.PastelLookup,
				DisplayFormat = dbPricelist.DisplayFormat,
				Flags = (PriceListFlags)dbPricelist.Flags
			};

			return voAccount;
		}
	}
}


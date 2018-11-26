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

		public static ValueObjects.Accounts.AccountMasterVO ToAccountMasterVO(this Accounts account, StockPricelists priceList,
			Accounts masterAccount, StockPricelists masterAccountPriceList)
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
				AccountAccountManagers = accountAccountManagers.Select(s => s.ToAccountAccountManagerVO()).ToList(),
				MasterAccount = masterAccount?.ToAccountMasterVO(masterAccountPriceList, null, null)
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

			if(priceList != null)
			{
				voAccount.PriceList = new ValueObjects.OrderEntry.PriceListVO
				{
					CompanyCode = priceList.CompanyCode,
					CurrencyCode = priceList.CurrencyCode,
					CurrencyName = priceList.CurrencyName,
					CurrencySymbol = priceList.CurrencySymbol,
					DateCreated = priceList.Created,
					DateLastModified = priceList.Modified ?? priceList.Created,
					DisplayIndex = priceList.DisplayIndex,
					DisplayName = priceList.DisplayName,
					HostId = priceList.XfxHostId,
					Id = priceList.Id,
					PastelLookup = priceList.PastelLookup,
					DisplayFormat = priceList.DisplayFormat,
					Flags = (PriceListFlags)priceList.Flags
				};
			}

			return voAccount;
		}
	}
}


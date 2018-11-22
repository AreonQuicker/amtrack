using System.Collections.Generic;
using Amtrack.ValueObjects.Accounts;

namespace Amtrack.Models.Cache
{
	public class AccountCacheModel : ICacheModel
	{
		public List<TaxRateVO> TaxRates { get; set; }
		public List<AccountMasterVO> Accounts { get; set; }
	}
}

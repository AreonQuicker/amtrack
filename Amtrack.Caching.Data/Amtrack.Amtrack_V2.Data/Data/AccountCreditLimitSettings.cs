using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AccountCreditLimitSettings
    {
        public int FkAccountId { get; set; }
        public int FkCreditLimitSettingsId { get; set; }

        public Accounts FkAccount { get; set; }
        public CreditLimitSettings FkCreditLimitSettings { get; set; }
    }
}

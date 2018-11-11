using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AccountCreditLimitSettings
    {
        public int FkAccountId { get; set; }
        public int FkCreditLimitSettingsId { get; set; }

        public Accounts FkAccount { get; set; }
        public CreditLimitSettings FkCreditLimitSettings { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AccountCreditLimitGroups
    {
        public long AccountId { get; set; }
        public long CreditLimitId { get; set; }

        public Account Account { get; set; }
        public CreditLimitGroups CreditLimit { get; set; }
    }
}

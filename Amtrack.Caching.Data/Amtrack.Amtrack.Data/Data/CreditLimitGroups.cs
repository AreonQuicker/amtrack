using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditLimitGroups
    {
        public CreditLimitGroups()
        {
            AccountCreditLimitGroups = new HashSet<AccountCreditLimitGroups>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool Blocked { get; set; }
        public int NearLimitPercentage { get; set; }
        public int OverCreditLimitAcceptablePercentage { get; set; }
        public double OverCreditLimitAcceptableValue { get; set; }
        public int OverCreditLimitToBlockOrderPercentage { get; set; }
        public double OverCreditLimitToBlockOrderValue { get; set; }
        public bool SendNearLimitNotification { get; set; }
        public bool SendBlockAccountNotification { get; set; }
        public bool SendOrderOnHoldNotification { get; set; }
        public long Flags { get; set; }
        public bool ShouldBlockedAccount { get; set; }
        public bool ShouldPutOrderOnHold { get; set; }

        public ICollection<AccountCreditLimitGroups> AccountCreditLimitGroups { get; set; }
    }
}

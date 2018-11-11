using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class CreditLimitSettings
    {
        public CreditLimitSettings()
        {
            AccountCreditLimitSettings = new HashSet<AccountCreditLimitSettings>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Blocked { get; set; }
        public int NearLimitPercentage { get; set; }
        public int OverCreditLimitAcceptablePercentage { get; set; }
        public double OverCreditLimitAcceptableValue { get; set; }
        public int OverCreditLimitPercentageToBlockOrder { get; set; }
        public double OverCreditLimitValueToBlockOrder { get; set; }
        public bool SendNearCreditLimitNotification { get; set; }
        public bool SendBlockAccountNotification { get; set; }
        public bool SendOrderOnHoldNotification { get; set; }
        public bool BlockAccount { get; set; }
        public bool PutOrderOnHold { get; set; }
        public long Flags { get; set; }

        public ICollection<AccountCreditLimitSettings> AccountCreditLimitSettings { get; set; }
    }
}

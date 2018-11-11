using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PaymentInformation
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Payment FkNavigation { get; set; }
        public Order PkNavigation { get; set; }
    }
}

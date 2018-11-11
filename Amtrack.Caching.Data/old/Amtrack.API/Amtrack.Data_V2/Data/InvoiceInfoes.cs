using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class InvoiceInfoes
    {
        public string DocumentNumber { get; set; }
        public string NotificationRecipientEmail { get; set; }
        public short? PriceRegime { get; set; }
        public string BranchCode { get; set; }
        public string UserUsername { get; set; }
        public string AuthorizerUsername { get; set; }
        public bool? BranchManually { get; set; }
    }
}

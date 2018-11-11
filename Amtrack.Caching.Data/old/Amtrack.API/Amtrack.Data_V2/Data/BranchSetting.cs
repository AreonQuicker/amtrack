using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchSetting
    {
        public long Id { get; set; }
        public long FkBranchId { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public int DaysWaitAtBranch { get; set; }
        public string Courier { get; set; }
        public string PhoneNumber { get; set; }
        public int DispatchedTime { get; set; }
        public string Country { get; set; }
        public int NumberOfTaxInvoicesToPrintOnHandOver { get; set; }
        public string CourierPdfpath { get; set; }
        public string CourierAddress { get; set; }

        public Branches FkBranch { get; set; }
    }
}

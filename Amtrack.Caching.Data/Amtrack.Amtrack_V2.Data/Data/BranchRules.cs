using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BranchRules
    {
        public BranchRules()
        {
            BranchRuleValues = new HashSet<BranchRuleValues>();
        }

        public long Id { get; set; }
        public int Type { get; set; }
        public long? FkBranchInvoiceTypeId { get; set; }
        public long? FkBranchInvoiceTypeShipmentId { get; set; }

        public BranchInvoiceType FkBranchInvoiceType { get; set; }
        public BranchInvoiceTypeShipment FkBranchInvoiceTypeShipment { get; set; }
        public ICollection<BranchRuleValues> BranchRuleValues { get; set; }
    }
}

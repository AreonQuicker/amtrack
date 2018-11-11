using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchInvoiceTypeShipment
    {
        public BranchInvoiceTypeShipment()
        {
            BranchRules = new HashSet<BranchRules>();
        }

        public long Id { get; set; }
        public long FkBranchInvoiceTypeId { get; set; }
        public int Type { get; set; }

        public BranchInvoiceType FkBranchInvoiceType { get; set; }
        public ICollection<BranchRules> BranchRules { get; set; }
    }
}

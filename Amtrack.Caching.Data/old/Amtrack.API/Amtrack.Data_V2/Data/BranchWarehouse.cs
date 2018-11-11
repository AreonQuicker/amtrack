using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchWarehouse
    {
        public BranchWarehouse()
        {
            BranchInvoiceTypeFkPrimaryBranchWarehouse = new HashSet<BranchInvoiceType>();
            BranchInvoiceTypeFkSecondaryBranchWarehouse = new HashSet<BranchInvoiceType>();
            BranchWarehouseLink = new HashSet<BranchWarehouseLink>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Flags { get; set; }

        public ICollection<BranchInvoiceType> BranchInvoiceTypeFkPrimaryBranchWarehouse { get; set; }
        public ICollection<BranchInvoiceType> BranchInvoiceTypeFkSecondaryBranchWarehouse { get; set; }
        public ICollection<BranchWarehouseLink> BranchWarehouseLink { get; set; }
    }
}

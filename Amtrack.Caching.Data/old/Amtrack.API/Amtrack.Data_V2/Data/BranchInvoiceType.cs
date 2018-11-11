using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchInvoiceType
    {
        public BranchInvoiceType()
        {
            BranchInvoiceTypeShipment = new HashSet<BranchInvoiceTypeShipment>();
            BranchRules = new HashSet<BranchRules>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string PastelInvoiceCode { get; set; }
        public string PastelDangerousGoodsCode { get; set; }
        public long? FkBranchId { get; set; }
        public long? FkPrimaryBranchId { get; set; }
        public int? FkPrimaryBranchWarehouseId { get; set; }
        public long? FkSecondaryBranchId { get; set; }
        public int? FkSecondaryBranchWarehouseId { get; set; }
        public int Priority { get; set; }

        public Branches FkBranch { get; set; }
        public Branches FkPrimaryBranch { get; set; }
        public BranchWarehouse FkPrimaryBranchWarehouse { get; set; }
        public Branches FkSecondaryBranch { get; set; }
        public BranchWarehouse FkSecondaryBranchWarehouse { get; set; }
        public ICollection<BranchInvoiceTypeShipment> BranchInvoiceTypeShipment { get; set; }
        public ICollection<BranchRules> BranchRules { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchWarehouseLink
    {
        public long FkBranchId { get; set; }
        public int FkBranchWarehouseId { get; set; }

        public Branches FkBranch { get; set; }
        public BranchWarehouse FkBranchWarehouse { get; set; }
    }
}

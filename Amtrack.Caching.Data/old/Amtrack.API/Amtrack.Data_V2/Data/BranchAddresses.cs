using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchAddresses
    {
        public long FkBranchId { get; set; }
        public int FkAddressId { get; set; }

        public Addresses FkAddress { get; set; }
        public Branches FkBranch { get; set; }
    }
}

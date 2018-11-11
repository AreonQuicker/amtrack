using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BranchAddresses
    {
        public long FkBranchId { get; set; }
        public int FkAddressId { get; set; }

        public Addresses FkAddress { get; set; }
        public Branches FkBranch { get; set; }
    }
}

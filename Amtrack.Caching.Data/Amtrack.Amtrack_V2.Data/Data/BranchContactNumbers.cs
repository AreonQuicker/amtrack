using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BranchContactNumbers
    {
        public long FkBranchId { get; set; }
        public int FkContactNumbersId { get; set; }

        public Branches FkBranch { get; set; }
        public ContactNumbers FkContactNumbers { get; set; }
    }
}

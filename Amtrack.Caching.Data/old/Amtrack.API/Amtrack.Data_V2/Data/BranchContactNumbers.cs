using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchContactNumbers
    {
        public long FkBranchId { get; set; }
        public int FkContactNumbersId { get; set; }

        public Branches FkBranch { get; set; }
        public ContactNumbers FkContactNumbers { get; set; }
    }
}

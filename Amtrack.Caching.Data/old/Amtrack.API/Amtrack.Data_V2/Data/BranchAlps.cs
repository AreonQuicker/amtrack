using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchAlps
    {
        public long FkBranchId { get; set; }
        public long FkAlpid { get; set; }

        public Alps FkAlp { get; set; }
        public Branches FkBranch { get; set; }
    }
}

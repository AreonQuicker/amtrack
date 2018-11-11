using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BranchAlps
    {
        public long FkBranchId { get; set; }
        public long FkAlpid { get; set; }

        public Alps FkAlp { get; set; }
        public Branches FkBranch { get; set; }
    }
}

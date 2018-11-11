using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BranchServers
    {
        public long FkBranchId { get; set; }
        public int FkServerId { get; set; }

        public Branches FkBranch { get; set; }
        public ServerDetails FkServer { get; set; }
    }
}

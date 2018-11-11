using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchServers
    {
        public long FkBranchId { get; set; }
        public int FkServerId { get; set; }

        public Branches FkBranch { get; set; }
        public ServerDetails FkServer { get; set; }
    }
}

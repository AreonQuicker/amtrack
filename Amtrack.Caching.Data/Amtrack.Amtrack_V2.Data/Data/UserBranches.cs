using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class UserBranches
    {
        public Guid FkUserId { get; set; }
        public long FkBranchId { get; set; }

        public Branches FkBranch { get; set; }
        public Users FkUser { get; set; }
    }
}

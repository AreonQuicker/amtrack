using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class UserBranches
    {
        public Guid FkUserId { get; set; }
        public long FkBranchId { get; set; }

        public Branches FkBranch { get; set; }
        public Users FkUser { get; set; }
    }
}

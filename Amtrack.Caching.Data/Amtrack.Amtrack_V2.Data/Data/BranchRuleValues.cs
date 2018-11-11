using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BranchRuleValues
    {
        public long Id { get; set; }
        public string Value { get; set; }
        public long FkBranchRuleId { get; set; }
        public int Index { get; set; }

        public BranchRules FkBranchRule { get; set; }
    }
}

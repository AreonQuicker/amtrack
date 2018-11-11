using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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

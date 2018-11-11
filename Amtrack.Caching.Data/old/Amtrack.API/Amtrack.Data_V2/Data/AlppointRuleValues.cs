using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AlppointRuleValues
    {
        public long Id { get; set; }
        public long FkAlppointsMultiplierRuleId { get; set; }
        public string Value { get; set; }
        public int Index { get; set; }

        public AlppointRules FkAlppointsMultiplierRule { get; set; }
    }
}

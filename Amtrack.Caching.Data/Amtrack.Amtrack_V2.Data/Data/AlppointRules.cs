using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AlppointRules
    {
        public AlppointRules()
        {
            AlppointRuleValues = new HashSet<AlppointRuleValues>();
            InverseFkAlppointRule = new HashSet<AlppointRules>();
        }

        public long Id { get; set; }
        public long? FkAlppointRuleId { get; set; }
        public long? FkAlpid { get; set; }
        public DateTime Created { get; set; }
        public double? Multiplier { get; set; }
        public double? Fixed { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
        public int Index { get; set; }

        public Alps FkAlp { get; set; }
        public AlppointRules FkAlppointRule { get; set; }
        public ICollection<AlppointRuleValues> AlppointRuleValues { get; set; }
        public ICollection<AlppointRules> InverseFkAlppointRule { get; set; }
    }
}

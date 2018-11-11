using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LdmPackingRuleValues
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int FkPackingRuleId { get; set; }
        public int QtyMin { get; set; }
        public int QtyMax { get; set; }
        public int Leadtime { get; set; }

        public LdmPackingRules FkPackingRule { get; set; }
    }
}

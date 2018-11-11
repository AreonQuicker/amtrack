using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LdmPackingRules
    {
        public LdmPackingRules()
        {
            LdmPackingRuleValues = new HashSet<LdmPackingRuleValues>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public int Flags { get; set; }

        public ICollection<LdmPackingRuleValues> LdmPackingRuleValues { get; set; }
    }
}

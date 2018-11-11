using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AlppointRuleBonusTypes
    {
        public long Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int Flags { get; set; }
        public int Index { get; set; }
    }
}

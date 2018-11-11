using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Alptargets
    {
        public long Id { get; set; }
        public long FkAlpid { get; set; }
        public DateTime Created { get; set; }
        public string DisplayName { get; set; }
        public int DisplayIndex { get; set; }
        public string ColorCode { get; set; }
        public double Value { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
        public double? CarryOverNextYearMultiplier { get; set; }

        public Alps FkAlp { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class DualJobCardLink
    {
        public long OrderId { get; set; }
        public long MasterJobId { get; set; }
        public long PositionMaster { get; set; }
        public long SubJobId { get; set; }
        public long PositionSub { get; set; }
        public long Id { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Alppromotion
    {
        public string ItemCode { get; set; }
        public double PointsMultiplier { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Alpoverride
    {
        public long Id { get; set; }
        public string ItemCodeClear { get; set; }
        public double PointsMultiplier { get; set; }
        public int Type { get; set; }
    }
}

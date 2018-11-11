using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class CreateInsuffiecients
    {
        public long Id { get; set; }
        public string ItemCode { get; set; }
        public int UnitsNeeded { get; set; }
        public int UnitsAvailable { get; set; }
        public short FromArea { get; set; }
        public string FkUserTracking { get; set; }
        public DateTime Created { get; set; }
    }
}

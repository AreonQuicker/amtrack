﻿using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ReservedStocks
    {
        public string ItemCode { get; set; }
        public int ReservedMain { get; set; }
        public int ReservedOvf { get; set; }
        public int ReservedBnd { get; set; }
        public int ReservedInc { get; set; }
        public int ReservedGlx { get; set; }
        public int ReservedWmd { get; set; }
        public int ReservedWbn { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AlpmultiplierOverride
    {
        public string ItemCode { get; set; }
        public double PointsMultiplier { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
    }
}

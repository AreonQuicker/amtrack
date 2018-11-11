﻿using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class TurnoverTransactionDetails
    {
        public long Id { get; set; }
        public long FkTurnoverId { get; set; }
        public Guid? FkLineId { get; set; }
        public double TotalDiff { get; set; }
        public string ItemCode { get; set; }
        public int ItemDiff { get; set; }
    }
}

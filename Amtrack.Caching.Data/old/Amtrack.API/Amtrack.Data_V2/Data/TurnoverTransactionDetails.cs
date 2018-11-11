using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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

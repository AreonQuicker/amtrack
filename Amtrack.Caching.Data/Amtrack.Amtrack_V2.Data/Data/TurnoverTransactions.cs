using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class TurnoverTransactions
    {
        public long TurnOverId { get; set; }
        public string DocumentNumber { get; set; }
        public short DocumentVersion { get; set; }
        public DateTime DateAdded { get; set; }
        public double TotalExcl { get; set; }
        public double TotalExclDiff { get; set; }
        public short Type { get; set; }
    }
}

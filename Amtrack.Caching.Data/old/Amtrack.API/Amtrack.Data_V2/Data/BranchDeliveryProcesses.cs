using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchDeliveryProcesses
    {
        public BranchDeliveryProcesses()
        {
            BranchDeliveryProcessTracking = new HashSet<BranchDeliveryProcessTracking>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string BranchPrefix { get; set; }
        public short Type { get; set; }
        public string Identifier { get; set; }
        public string FromFile { get; set; }
        public bool Error { get; set; }
        public bool Processed { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string VParam1 { get; set; }
        public string VParam2 { get; set; }

        public ICollection<BranchDeliveryProcessTracking> BranchDeliveryProcessTracking { get; set; }
    }
}

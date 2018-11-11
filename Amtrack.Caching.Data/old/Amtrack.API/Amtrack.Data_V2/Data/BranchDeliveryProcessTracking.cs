using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchDeliveryProcessTracking
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public short Type { get; set; }
        public string TrackDescription { get; set; }
        public long FkBranchDeliveryProcessId { get; set; }

        public BranchDeliveryProcesses FkBranchDeliveryProcess { get; set; }
    }
}

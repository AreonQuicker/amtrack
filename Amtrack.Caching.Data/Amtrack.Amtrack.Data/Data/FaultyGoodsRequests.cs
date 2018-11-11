using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class FaultyGoodsRequests
    {
        public int RequestId { get; set; }
        public long LineId { get; set; }
        public DateTime DateRequested { get; set; }
        public long RequestedBy { get; set; }
        public int RequestedQuantity { get; set; }
        public long? FullfilledBy { get; set; }
        public DateTime? FullfilledDate { get; set; }
        public DateTime? DateClosed { get; set; }
        public long? ClosedBy { get; set; }

        public User ClosedByNavigation { get; set; }
        public User FullfilledByNavigation { get; set; }
        public Line Line { get; set; }
        public User RequestedByNavigation { get; set; }
    }
}

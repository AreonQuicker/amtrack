using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class SystemRequestTracking
    {
        public long SystemRequestId { get; set; }
        public long TrackingId { get; set; }

        public SystemRequest SystemRequest { get; set; }
        public Tracking Tracking { get; set; }
    }
}

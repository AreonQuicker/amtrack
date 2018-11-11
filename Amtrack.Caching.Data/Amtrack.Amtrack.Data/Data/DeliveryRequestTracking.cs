using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class DeliveryRequestTracking
    {
        public long DeliveryRequestId { get; set; }
        public long TrackingId { get; set; }

        public DeliveryRequest DeliveryRequest { get; set; }
        public Tracking Tracking { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class DeliveryRequestContents
    {
        public long Id { get; set; }
        public long DeliveryRequestId { get; set; }
        public long OrderId { get; set; }

        public DeliveryRequest DeliveryRequest { get; set; }
        public Order Order { get; set; }
    }
}

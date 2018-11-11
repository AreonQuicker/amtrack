using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DeliveryWaybillCourierDetails
    {
        public int Id { get; set; }
        public string ContactNumber { get; set; }
        public string Courier { get; set; }
        public string TrackingNumber { get; set; }
    }
}

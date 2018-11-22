using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DeliveryWaybillCourierDetails
    {
        public DeliveryWaybillCourierDetails()
        {
            DeliveryWaybill = new HashSet<DeliveryWaybill>();
        }

        public int Id { get; set; }
        public string ContactNumber { get; set; }
        public string Courier { get; set; }
        public string TrackingNumber { get; set; }

        public ICollection<DeliveryWaybill> DeliveryWaybill { get; set; }
    }
}

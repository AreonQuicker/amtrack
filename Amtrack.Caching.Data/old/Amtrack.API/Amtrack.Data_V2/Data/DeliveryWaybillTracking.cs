using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DeliveryWaybillTracking
    {
        public int Id { get; set; }
        public int FkDeliveryWaybillId { get; set; }
        public long? UserId { get; set; }
        public DateTime Created { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }

        public DeliveryWaybill FkDeliveryWaybill { get; set; }
    }
}

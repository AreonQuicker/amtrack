using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchDeliveryCourierInfoes
    {
        public long Id { get; set; }
        public long FkBranchDeliveryId { get; set; }
        public string ShipmentId { get; set; }
        public string ParcelId { get; set; }

        public BranchDelivery FkBranchDelivery { get; set; }
    }
}

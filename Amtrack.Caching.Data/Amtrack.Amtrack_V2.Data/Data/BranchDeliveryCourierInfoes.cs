using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
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

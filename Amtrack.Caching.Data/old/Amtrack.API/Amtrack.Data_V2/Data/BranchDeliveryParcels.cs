using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchDeliveryParcels
    {
        public long Id { get; set; }
        public long FkBranchDeliveryId { get; set; }
        public long ParcelId { get; set; }

        public BranchDelivery FkBranchDelivery { get; set; }
    }
}

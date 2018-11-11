using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BranchDeliveryParcels
    {
        public long Id { get; set; }
        public long FkBranchDeliveryId { get; set; }
        public long ParcelId { get; set; }

        public BranchDelivery FkBranchDelivery { get; set; }
    }
}

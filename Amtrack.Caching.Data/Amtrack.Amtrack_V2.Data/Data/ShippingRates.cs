using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ShippingRates
    {
        public int RateId { get; set; }
        public DateTime Created { get; set; }
        public float MinimumCharge { get; set; }
        public short MinimumWeight { get; set; }
        public float RatePerKg { get; set; }
        public float RegionalRatePerKg { get; set; }
        public float OutlyingRatePerKm { get; set; }
        public long Flags { get; set; }
        public int FkShippingDestinationId { get; set; }

        public ShippingDestinations FkShippingDestination { get; set; }
    }
}

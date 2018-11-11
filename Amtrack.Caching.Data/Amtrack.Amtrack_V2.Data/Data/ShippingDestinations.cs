using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ShippingDestinations
    {
        public ShippingDestinations()
        {
            ShippingRates = new HashSet<ShippingRates>();
        }

        public int ShippingDestinationId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public short TownType { get; set; }
        public short ServiceType { get; set; }
        public short OutlyingKm { get; set; }
        public long Flags { get; set; }
        public int FkShippingServiceId { get; set; }

        public ShippingServices FkShippingService { get; set; }
        public ICollection<ShippingRates> ShippingRates { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ShippingServices
    {
        public ShippingServices()
        {
            ShippingDestinations = new HashSet<ShippingDestinations>();
        }

        public int ShippingServiceId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public long Flags { get; set; }
        public int FkShippingProviderId { get; set; }

        public ShippingProviders FkShippingProvider { get; set; }
        public ICollection<ShippingDestinations> ShippingDestinations { get; set; }
    }
}

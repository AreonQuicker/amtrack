using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ShippingProviders
    {
        public ShippingProviders()
        {
            ShippingProviderConfigurations = new HashSet<ShippingProviderConfigurations>();
            ShippingServices = new HashSet<ShippingServices>();
        }

        public int ShippingProviderId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public long Flags { get; set; }

        public ICollection<ShippingProviderConfigurations> ShippingProviderConfigurations { get; set; }
        public ICollection<ShippingServices> ShippingServices { get; set; }
    }
}

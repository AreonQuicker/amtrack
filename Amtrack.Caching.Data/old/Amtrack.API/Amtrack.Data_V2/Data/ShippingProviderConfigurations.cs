using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ShippingProviderConfigurations
    {
        public int ConfigurationId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public long Flags { get; set; }
        public int FkShippingProviderId { get; set; }

        public ShippingProviders FkShippingProvider { get; set; }
    }
}

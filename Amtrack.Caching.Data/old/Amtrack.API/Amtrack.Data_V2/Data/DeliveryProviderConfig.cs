using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DeliveryProviderConfig
    {
        public int Id { get; set; }
        public int FkDeliveryProviderId { get; set; }
        public string ApiproviderEndPoint { get; set; }

        public DeliveryProvider FkDeliveryProvider { get; set; }
    }
}

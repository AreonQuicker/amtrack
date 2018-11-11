using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DeliveryProviderConfig
    {
        public int Id { get; set; }
        public int FkDeliveryProviderId { get; set; }
        public string ApiproviderEndPoint { get; set; }

        public DeliveryProvider FkDeliveryProvider { get; set; }
    }
}

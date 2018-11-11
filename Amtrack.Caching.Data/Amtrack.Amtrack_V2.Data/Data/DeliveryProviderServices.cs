using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DeliveryProviderServices
    {
        public int Id { get; set; }
        public int FkDeliveryProviderId { get; set; }
        public string Service { get; set; }
        public string Code { get; set; }

        public DeliveryProvider FkDeliveryProvider { get; set; }
    }
}

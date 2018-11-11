using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DeliveryProviderServiceExclusions
    {
        public int Id { get; set; }
        public int FkDeliveryProviderId { get; set; }
        public string ServiceCode { get; set; }
        public int FkItemId { get; set; }

        public DeliveryProvider FkDeliveryProvider { get; set; }
    }
}

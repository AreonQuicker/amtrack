using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DeliveryProviderServiceLeadTimes
    {
        public int FkDeliveryProviderId { get; set; }
        public string ServiceCode { get; set; }
        public string Zone { get; set; }
        public string LeadTime { get; set; }

        public DeliveryProvider FkDeliveryProvider { get; set; }
    }
}

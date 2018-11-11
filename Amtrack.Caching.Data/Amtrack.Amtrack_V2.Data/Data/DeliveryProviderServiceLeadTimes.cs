using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
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

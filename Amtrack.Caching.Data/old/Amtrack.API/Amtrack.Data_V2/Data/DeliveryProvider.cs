using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class DeliveryProvider
    {
        public DeliveryProvider()
        {
            DeliveryProviderConfig = new HashSet<DeliveryProviderConfig>();
            DeliveryProviderServiceExclusions = new HashSet<DeliveryProviderServiceExclusions>();
            DeliveryProviderServiceLeadTimes = new HashSet<DeliveryProviderServiceLeadTimes>();
            DeliveryProviderServices = new HashSet<DeliveryProviderServices>();
            DeliveryQuote = new HashSet<DeliveryQuote>();
            DeliverySuburbLookup = new HashSet<DeliverySuburbLookup>();
            DeliveryWaybill = new HashSet<DeliveryWaybill>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }

        public ICollection<DeliveryProviderConfig> DeliveryProviderConfig { get; set; }
        public ICollection<DeliveryProviderServiceExclusions> DeliveryProviderServiceExclusions { get; set; }
        public ICollection<DeliveryProviderServiceLeadTimes> DeliveryProviderServiceLeadTimes { get; set; }
        public ICollection<DeliveryProviderServices> DeliveryProviderServices { get; set; }
        public ICollection<DeliveryQuote> DeliveryQuote { get; set; }
        public ICollection<DeliverySuburbLookup> DeliverySuburbLookup { get; set; }
        public ICollection<DeliveryWaybill> DeliveryWaybill { get; set; }
    }
}

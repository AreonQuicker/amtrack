using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class DeliveryRequest
    {
        public DeliveryRequest()
        {
            DeliveryRequestContents = new HashSet<DeliveryRequestContents>();
            DeliveryRequestTracking = new HashSet<DeliveryRequestTracking>();
        }

        public long Id { get; set; }
        public Guid Guid { get; set; }
        public long AccountId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public string ContactNameAlternate { get; set; }
        public string ContactNumberAlternate { get; set; }
        public string DeliveryText { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string DeliveryAddress { get; set; }
        public string DeliveryArea { get; set; }
        public string Driver { get; set; }
        public int CurrentState { get; set; }
        public long Author { get; set; }
        public DateTime Created { get; set; }
        public int? Flags { get; set; }

        public Account Account { get; set; }
        public ICollection<DeliveryRequestContents> DeliveryRequestContents { get; set; }
        public ICollection<DeliveryRequestTracking> DeliveryRequestTracking { get; set; }
    }
}

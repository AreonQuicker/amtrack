using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BranchDeliveryRequestResponses
    {
        public Guid ResponseId { get; set; }
        public DateTime Created { get; set; }
        public string Branch { get; set; }
        public Guid BranchDeliveryRequestId { get; set; }
        public string ReferenceNumber { get; set; }

        public BranchDeliveryRequests BranchDeliveryRequest { get; set; }
    }
}

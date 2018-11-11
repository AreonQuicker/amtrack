using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchDeliveryRequests
    {
        public BranchDeliveryRequests()
        {
            BranchDeliveryRequestResponses = new HashSet<BranchDeliveryRequestResponses>();
        }

        public Guid BranchDeliveryRequestId { get; set; }
        public DateTime Created { get; set; }
        public string DocumentNumber { get; set; }
        public string Branch { get; set; }
        public string Recipient { get; set; }
        public string ReferenceNumber { get; set; }
        public int Flags { get; set; }

        public ICollection<BranchDeliveryRequestResponses> BranchDeliveryRequestResponses { get; set; }
    }
}

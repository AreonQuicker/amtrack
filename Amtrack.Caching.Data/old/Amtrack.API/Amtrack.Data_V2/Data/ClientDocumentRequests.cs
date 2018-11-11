using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ClientDocumentRequests
    {
        public ClientDocumentRequests()
        {
            ClientDocumentResponses = new HashSet<ClientDocumentResponses>();
        }

        public Guid ClientRequestId { get; set; }
        public DateTime Created { get; set; }
        public string DocumentNumber { get; set; }
        public short RequestType { get; set; }
        public string Recipient { get; set; }
        public string ReferenceNumber { get; set; }
        public short Status { get; set; }

        public ICollection<ClientDocumentResponses> ClientDocumentResponses { get; set; }
    }
}

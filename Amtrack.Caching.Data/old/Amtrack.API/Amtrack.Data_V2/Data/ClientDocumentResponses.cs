using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ClientDocumentResponses
    {
        public Guid ResponseId { get; set; }
        public DateTime Created { get; set; }
        public short ResponseValue { get; set; }
        public string ReferenceNumber { get; set; }
        public Guid ClientDocumentRequestClientRequestId { get; set; }

        public ClientDocumentRequests ClientDocumentRequestClientRequest { get; set; }
    }
}

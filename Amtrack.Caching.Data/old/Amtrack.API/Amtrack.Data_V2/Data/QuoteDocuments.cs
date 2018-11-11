using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class QuoteDocuments
    {
        public Guid QuoteDocumentId { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime DocumentDate { get; set; }
        public short DocumentType { get; set; }
        public string CustomerCode { get; set; }
        public string DocumentCreatetor { get; set; }
        public string Email { get; set; }
        public string AccountManager { get; set; }
        public string Message { get; set; }
    }
}

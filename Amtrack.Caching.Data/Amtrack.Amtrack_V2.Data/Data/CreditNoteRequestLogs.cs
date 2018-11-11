using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class CreditNoteRequestLogs
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int? CreditNoteRequestId { get; set; }
        public string ReferenceNumber { get; set; }
        public bool? RequestCreated { get; set; }
        public bool? Approved { get; set; }
        public bool? Decline { get; set; }
        public bool? InvoiceCreated { get; set; }
        public bool? CreditNoteCreated { get; set; }
        public bool? InventoryCreated { get; set; }
        public bool? Success { get; set; }
    }
}

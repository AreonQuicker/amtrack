using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class CreditNoteRequestProcesses
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkCreditNoteRequestId { get; set; }
        public string ReferenceNumber { get; set; }
        public bool? IsCreditRequestCreated { get; set; }
        public bool? IsCreditRequestApproved { get; set; }
        public bool? IsCreditRequestDeclined { get; set; }
        public bool? IsInvoiceCreated { get; set; }
        public bool? IsCreditNoteCreated { get; set; }
        public bool? IsInventoryCreated { get; set; }
        public bool? Success { get; set; }
    }
}

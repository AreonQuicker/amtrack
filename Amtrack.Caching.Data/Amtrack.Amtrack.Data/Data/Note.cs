using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Note
    {
        public Note()
        {
            CreditNoteRequestNotes = new HashSet<CreditNoteRequestNotes>();
            CreditNoteRequestPaymentApprovedNotes = new HashSet<CreditNoteRequestPaymentApprovedNotes>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public bool Block { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public long Flags { get; set; }

        public AccountNotes AccountNotes { get; set; }
        public JobCardCustomerNotes JobCardCustomerNotes { get; set; }
        public JobCardNotes JobCardNotes { get; set; }
        public Notes Notes { get; set; }
        public OrderCustomerNotes OrderCustomerNotes { get; set; }
        public OrderNotes OrderNotes { get; set; }
        public ICollection<CreditNoteRequestNotes> CreditNoteRequestNotes { get; set; }
        public ICollection<CreditNoteRequestPaymentApprovedNotes> CreditNoteRequestPaymentApprovedNotes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNoteRequestPaymentApprovedNotes
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Note FkNavigation { get; set; }
        public CreditNoteRequest PkNavigation { get; set; }
    }
}

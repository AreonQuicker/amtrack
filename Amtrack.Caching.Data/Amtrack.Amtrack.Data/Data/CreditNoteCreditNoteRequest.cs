using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNoteCreditNoteRequest
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public CreditNoteRequest FkNavigation { get; set; }
        public CreditNote PkNavigation { get; set; }
    }
}

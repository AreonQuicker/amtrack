using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNoteAttachments
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public CreditNoteAttachment FkNavigation { get; set; }
        public CreditNote PkNavigation { get; set; }
    }
}

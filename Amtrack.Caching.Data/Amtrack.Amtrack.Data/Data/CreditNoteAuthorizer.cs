using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNoteAuthorizer
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public User FkNavigation { get; set; }
        public CreditNoteRequest PkNavigation { get; set; }
    }
}

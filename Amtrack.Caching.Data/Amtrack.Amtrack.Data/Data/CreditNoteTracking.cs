using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNoteTracking
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Tracking FkNavigation { get; set; }
        public CreditNote PkNavigation { get; set; }
    }
}

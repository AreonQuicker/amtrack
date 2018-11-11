using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNoteRequestDetail
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Line FkNavigation { get; set; }
        public CreditNoteRequest PkNavigation { get; set; }
    }
}

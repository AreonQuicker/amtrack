using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNoteRequestOrder
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Order FkNavigation { get; set; }
        public CreditNoteRequest PkNavigation { get; set; }
    }
}

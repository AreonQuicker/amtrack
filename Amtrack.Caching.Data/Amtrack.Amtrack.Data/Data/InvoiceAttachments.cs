using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class InvoiceAttachments
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public InvoiceAttachment FkNavigation { get; set; }
        public Order PkNavigation { get; set; }
    }
}

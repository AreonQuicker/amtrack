using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class OrderCustomerNotes
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Note FkNavigation { get; set; }
        public Order PkNavigation { get; set; }
    }
}

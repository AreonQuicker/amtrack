using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class QuoteItems
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public QuoteItem FkNavigation { get; set; }
        public Quote PkNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AccountQuotes
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Quote FkNavigation { get; set; }
        public Account PkNavigation { get; set; }
    }
}

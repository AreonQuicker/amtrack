using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CustomerQuotes
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Quote FkNavigation { get; set; }
        public Customer PkNavigation { get; set; }
    }
}

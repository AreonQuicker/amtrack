using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StockPrice
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Price FkNavigation { get; set; }
        public Stock PkNavigation { get; set; }
    }
}

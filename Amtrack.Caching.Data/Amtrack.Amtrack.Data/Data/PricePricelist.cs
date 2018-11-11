using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PricePricelist
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Pricelist FkNavigation { get; set; }
        public Price PkNavigation { get; set; }
    }
}

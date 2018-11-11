using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Price
    {
        public Price()
        {
            PricePricelist = new HashSet<PricePricelist>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public decimal UnitPrice { get; set; }

        public StockPrice StockPrice { get; set; }
        public ICollection<PricePricelist> PricePricelist { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Stock
    {
        public Stock()
        {
            StockPrice = new HashSet<StockPrice>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string StockCode { get; set; }
        public string Description { get; set; }

        public InventoryStock InventoryStock { get; set; }
        public ICollection<StockPrice> StockPrice { get; set; }
    }
}

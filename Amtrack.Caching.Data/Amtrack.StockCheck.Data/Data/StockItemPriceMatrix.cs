using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemPriceMatrix
    {
        public long Id { get; set; }
        public int FkItemId { get; set; }
        public int FkPricelistId { get; set; }
        public double Price { get; set; }
        public int Flags { get; set; }

        public StockItemMaster FkItem { get; set; }
        public StockPricelists FkPricelist { get; set; }
    }
}

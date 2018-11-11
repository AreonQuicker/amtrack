using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockEmbroideryPricing
    {
        public int Id { get; set; }
        public int FkPriceListId { get; set; }
        public string PriceCode { get; set; }
        public int QuantityLow { get; set; }
        public int QuantityHigh { get; set; }
        public double Price { get; set; }

        public StockPricelists FkPriceList { get; set; }
    }
}

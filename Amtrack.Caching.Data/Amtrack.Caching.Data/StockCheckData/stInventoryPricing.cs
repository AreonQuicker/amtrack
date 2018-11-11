using System;
using System.Collections.Generic;
using System.Text;

namespace Amtrack.Caching.Data.StockCheckData
{
    public class stInventoryPricing
    {
        public stInventoryPricing()
        {
            
        }

        public string ItemCode { get; set; }
        public double Price { get; set; }
        public int PricelistId { get; set; }
    }
}

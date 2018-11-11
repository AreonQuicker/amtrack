using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockPallets2
    {
        public string ItemCode { get; set; }
        public string StoreCode { get; set; }
        public int InWarehouseLevel { get; set; }
        public int InLocationLevel { get; set; }
        public int ToBePlacedLevel { get; set; }
        public int InTransitTo { get; set; }
        public int InTransitFrom { get; set; }
    }
}

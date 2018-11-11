using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockWmsChange
    {
        public string ItemCode { get; set; }
        public string StoreCode { get; set; }
        public int OldLevel { get; set; }
        public int NewLevel { get; set; }
        public int Flags { get; set; }
    }
}

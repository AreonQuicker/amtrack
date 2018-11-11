using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockSetStockcheck
    {
        public string GiftSetItemCode { get; set; }
        public int Jhb { get; set; }
        public int Bo { get; set; }
        public int Ic { get; set; }
        public DateTime? Eta { get; set; }
    }
}

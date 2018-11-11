using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditReceipt
    {
        public long Id { get; set; }
        public string Number { get; set; }
        public string StockItem { get; set; }
        public int Qty { get; set; }
        public long UomProfileId { get; set; }
        public long UomId { get; set; }
    }
}

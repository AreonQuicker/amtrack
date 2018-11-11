using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemBranchAttributes
    {
        public long Id { get; set; }
        public long FkBranchId { get; set; }
        public int FkItemId { get; set; }
        public string InboundTariffCode { get; set; }

        public StockItemMaster FkItem { get; set; }
    }
}

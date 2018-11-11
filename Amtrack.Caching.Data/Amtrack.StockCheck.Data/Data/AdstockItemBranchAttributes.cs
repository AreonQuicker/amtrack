using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class AdstockItemBranchAttributes
    {
        public long Id { get; set; }
        public DateTime ActionDate { get; set; }
        public string Action { get; set; }
        public long FkBranchId { get; set; }
        public int FkItemId { get; set; }
        public string InboundTariffCode { get; set; }
    }
}

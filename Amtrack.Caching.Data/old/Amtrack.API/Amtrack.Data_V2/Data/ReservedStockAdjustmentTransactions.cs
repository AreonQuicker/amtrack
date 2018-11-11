using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ReservedStockAdjustmentTransactions
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Picker { get; set; }
        public string ItemCode { get; set; }
        public long QueryId { get; set; }
        public string FromWarehouse { get; set; }
        public string ToWarehouse { get; set; }
        public int Quantity { get; set; }
        public string MiniPallet { get; set; }
    }
}

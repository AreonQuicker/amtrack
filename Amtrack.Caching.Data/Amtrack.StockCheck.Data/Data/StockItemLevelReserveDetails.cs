using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemLevelReserveDetails
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int FkItemLevelId { get; set; }
        public int FkItemLevelSourceId { get; set; }
        public string Reference { get; set; }
        public string Reference2 { get; set; }
        public int Quantity { get; set; }
        public int Flags { get; set; }

        public StockItemLevel FkItemLevel { get; set; }
        public StockItemLevelSource FkItemLevelSource { get; set; }
    }
}

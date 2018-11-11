using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemLevel
    {
        public StockItemLevel()
        {
            StockItemLevelDetail = new HashSet<StockItemLevelDetail>();
            StockItemLevelIncomingDetails = new HashSet<StockItemLevelIncomingDetails>();
            StockItemLevelReserveDetails = new HashSet<StockItemLevelReserveDetails>();
        }

        public int Id { get; set; }
        public DateTime Modified { get; set; }
        public int FkItemId { get; set; }
        public int OnHand { get; set; }
        public int Suspense { get; set; }

        public StockItemMaster FkItem { get; set; }
        public ICollection<StockItemLevelDetail> StockItemLevelDetail { get; set; }
        public ICollection<StockItemLevelIncomingDetails> StockItemLevelIncomingDetails { get; set; }
        public ICollection<StockItemLevelReserveDetails> StockItemLevelReserveDetails { get; set; }
    }
}

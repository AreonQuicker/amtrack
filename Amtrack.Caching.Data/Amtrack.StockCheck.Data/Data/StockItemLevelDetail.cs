using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemLevelDetail
    {
        public StockItemLevelDetail()
        {
            StockItemLevelTransactions = new HashSet<StockItemLevelTransactions>();
        }

        public int Id { get; set; }
        public int FkLevelId { get; set; }
        public int FkItemLevelDetailType { get; set; }
        public int FkItemLevelSourceId { get; set; }
        public int OnHand { get; set; }
        public int Suspense { get; set; }
        public int Flags { get; set; }

        public StockItemLevelDetailType FkItemLevelDetailTypeNavigation { get; set; }
        public StockItemLevelSource FkItemLevelSource { get; set; }
        public StockItemLevel FkLevel { get; set; }
        public ICollection<StockItemLevelTransactions> StockItemLevelTransactions { get; set; }
    }
}

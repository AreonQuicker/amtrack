using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemPublication
    {
        public StockItemPublication()
        {
            StockItemPublicationTransactions = new HashSet<StockItemPublicationTransactions>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int FkItemId { get; set; }
        public int FkDetailLevelSourceId { get; set; }
        public int Flags { get; set; }

        public StockItemLevelSource FkDetailLevelSource { get; set; }
        public StockItemMaster FkItem { get; set; }
        public ICollection<StockItemPublicationTransactions> StockItemPublicationTransactions { get; set; }
    }
}

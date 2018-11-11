using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockInventoryTransactionTypes
    {
        public StockInventoryTransactionTypes()
        {
            StockItemLevelTransactions = new HashSet<StockItemLevelTransactions>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }

        public ICollection<StockItemLevelTransactions> StockItemLevelTransactions { get; set; }
    }
}

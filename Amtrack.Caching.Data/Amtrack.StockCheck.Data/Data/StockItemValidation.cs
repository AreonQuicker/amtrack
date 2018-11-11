using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemValidation
    {
        public StockItemValidation()
        {
            StockItemValidationTransactions = new HashSet<StockItemValidationTransactions>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int FkItemId { get; set; }
        public int FkDetailLevelSourceId { get; set; }
        public int Flags { get; set; }

        public StockItemLevelSource FkDetailLevelSource { get; set; }
        public StockItemMaster FkItem { get; set; }
        public ICollection<StockItemValidationTransactions> StockItemValidationTransactions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemLevelTransactions
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkTransactionTypeId { get; set; }
        public int FkLevelDetailId { get; set; }
        public string Originator { get; set; }
        public string Reference { get; set; }
        public string Reference2 { get; set; }
        public int OnHand { get; set; }
        public int Suspense { get; set; }
        public int Flags { get; set; }

        public StockItemLevelDetail FkLevelDetail { get; set; }
        public StockInventoryTransactionTypes FkTransactionType { get; set; }
    }
}

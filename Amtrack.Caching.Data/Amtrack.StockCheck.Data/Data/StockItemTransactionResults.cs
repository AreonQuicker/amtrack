using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemTransactionResults
    {
        public StockItemTransactionResults()
        {
            StockItemPublicationTransactions = new HashSet<StockItemPublicationTransactions>();
            StockItemValidationTransactions = new HashSet<StockItemValidationTransactions>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }

        public ICollection<StockItemPublicationTransactions> StockItemPublicationTransactions { get; set; }
        public ICollection<StockItemValidationTransactions> StockItemValidationTransactions { get; set; }
    }
}

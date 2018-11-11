using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemValidationTransactions
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkValidationId { get; set; }
        public int Result { get; set; }
        public string ResultMessage { get; set; }
        public int Flags { get; set; }

        public StockItemValidation FkValidation { get; set; }
        public StockItemTransactionResults ResultNavigation { get; set; }
    }
}

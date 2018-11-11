using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemPublicationTransactions
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkPublicationId { get; set; }
        public int Result { get; set; }
        public string ResultMessage { get; set; }
        public int Flags { get; set; }

        public StockItemPublication FkPublication { get; set; }
        public StockItemTransactionResults ResultNavigation { get; set; }
    }
}

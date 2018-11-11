using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemLevelSource
    {
        public StockItemLevelSource()
        {
            StockItemLevelDetail = new HashSet<StockItemLevelDetail>();
            StockItemLevelIncomingDetails = new HashSet<StockItemLevelIncomingDetails>();
            StockItemLevelReserveDetails = new HashSet<StockItemLevelReserveDetails>();
            StockItemPublication = new HashSet<StockItemPublication>();
            StockItemValidation = new HashSet<StockItemValidation>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Flags { get; set; }

        public ICollection<StockItemLevelDetail> StockItemLevelDetail { get; set; }
        public ICollection<StockItemLevelIncomingDetails> StockItemLevelIncomingDetails { get; set; }
        public ICollection<StockItemLevelReserveDetails> StockItemLevelReserveDetails { get; set; }
        public ICollection<StockItemPublication> StockItemPublication { get; set; }
        public ICollection<StockItemValidation> StockItemValidation { get; set; }
    }
}

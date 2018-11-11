using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class StockTakeBatches
    {
        public StockTakeBatches()
        {
            StockTakeRecords = new HashSet<StockTakeRecords>();
            StockTakeUnProcessedBatchEntries = new HashSet<StockTakeUnProcessedBatchEntries>();
        }

        public Guid BatchId { get; set; }
        public DateTime Started { get; set; }
        public DateTime? Closed { get; set; }
        public short ClassType { get; set; }
        public string Number { get; set; }
        public Guid AuthorId { get; set; }
        public byte Status { get; set; }
        public int Flags { get; set; }

        public ICollection<StockTakeRecords> StockTakeRecords { get; set; }
        public ICollection<StockTakeUnProcessedBatchEntries> StockTakeUnProcessedBatchEntries { get; set; }
    }
}

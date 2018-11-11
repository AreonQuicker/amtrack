using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class StockTakeUnProcessedBatchEntries
    {
        public Guid BatchEntryId { get; set; }
        public Guid AuthorId { get; set; }
        public string EntryKey { get; set; }
        public Guid? LocationId { get; set; }
        public short EntryType { get; set; }
        public DateTime DateScanned { get; set; }
        public long Flags { get; set; }
        public Guid FkStockTakeBatchId { get; set; }

        public StockTakeBatches FkStockTakeBatch { get; set; }
    }
}

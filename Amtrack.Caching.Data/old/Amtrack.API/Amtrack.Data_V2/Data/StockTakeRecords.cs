using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class StockTakeRecords
    {
        public Guid RecordId { get; set; }
        public string ScannedItem { get; set; }
        public string ExpectedItem { get; set; }
        public byte RecordType { get; set; }
        public long? LegacyLocationId { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? ResolvedUserId { get; set; }
        public byte ResolvedType { get; set; }
        public string ResolvedComment { get; set; }
        public DateTime? ResolvedDate { get; set; }
        public int Flags { get; set; }
        public Guid FkStockTakeBatchId { get; set; }

        public StockTakeBatches FkStockTakeBatch { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BatchStockContent
    {
        public int Id { get; set; }
        public long FkBatchId { get; set; }
        public long FkOrderId { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public int? Status { get; set; }
        public long? Flags { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BatchedShipments
    {
        public long FkBatchId { get; set; }
        public long FkShipmentId { get; set; }

        public Batch FkBatch { get; set; }
    }
}

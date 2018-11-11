using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LinkedBatches
    {
        public long BatchId { get; set; }
        public long FkLinkBatchId { get; set; }

        public Batch Batch { get; set; }
        public Batch FkLinkBatch { get; set; }
    }
}

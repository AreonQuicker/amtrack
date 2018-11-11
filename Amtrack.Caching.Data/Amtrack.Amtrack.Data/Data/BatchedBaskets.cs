using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BatchedBaskets
    {
        public long FkBatch { get; set; }
        public long FkBasket { get; set; }

        public Batch FkBatchNavigation { get; set; }
    }
}

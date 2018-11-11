using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Wc15ReceivedSampleBatches
    {
        public long FkOrderId { get; set; }
        public string StyleCode { get; set; }
        public bool Received { get; set; }
        public DateTime DateReceived { get; set; }
        public long ReceivedOnBatch { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ClBatchContents
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public long FkBatchId { get; set; }
        public long FkOrderId { get; set; }
        public long FkUserId { get; set; }
        public string TerminalIp { get; set; }
        public int SgStatus { get; set; }
        public int Flags { get; set; }

        public Batch FkBatch { get; set; }
        public Order FkOrder { get; set; }
        public User FkUser { get; set; }
    }
}

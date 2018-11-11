using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Notification
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public int Type { get; set; }
        public int Function { get; set; }
        public int Format { get; set; }
        public int Status { get; set; }
        public byte[] Data { get; set; }
        public string Recipients { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string FailureReason { get; set; }
    }
}

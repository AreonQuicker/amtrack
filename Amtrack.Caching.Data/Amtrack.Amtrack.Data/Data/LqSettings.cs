using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqSettings
    {
        public long Id { get; set; }
        public long? FkUserId { get; set; }
        public DateTime Created { get; set; }
        public string QueueTypeCode { get; set; }
        public int? RefreshRate { get; set; }
        public int? LeadTime { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class MTracking
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public Guid RecipientId { get; set; }
        public long? FkMessage { get; set; }
        public long? FkSchedule { get; set; }
        public long? FkStore { get; set; }
        public long? FkDocument { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }
    }
}

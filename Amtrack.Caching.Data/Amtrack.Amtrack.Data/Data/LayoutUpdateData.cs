using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LayoutUpdateData
    {
        public long Id { get; set; }
        public long FkJobCardId { get; set; }
        public DateTime JobCardCreated { get; set; }
        public long FkCreatedUserId { get; set; }
        public DateTime? JobCardUpdated { get; set; }
        public long? FkUpdatedUserId { get; set; }
        public long? Flags { get; set; }
    }
}

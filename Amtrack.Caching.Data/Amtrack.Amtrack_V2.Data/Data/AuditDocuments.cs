using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AuditDocuments
    {
        public int AId { get; set; }
        public DateTime Created { get; set; }
        public Guid DocumentId { get; set; }
        public long Status { get; set; }
        public long Flags { get; set; }
    }
}

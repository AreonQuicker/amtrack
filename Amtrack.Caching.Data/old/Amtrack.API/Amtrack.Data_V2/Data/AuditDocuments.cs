using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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

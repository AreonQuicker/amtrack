using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class UtiBondedIntegrationAudit
    {
        public long Id { get; set; }
        public int MessageId { get; set; }
        public DateTime Created { get; set; }
        public string FileLocation { get; set; }
        public int ItemCount { get; set; }
    }
}

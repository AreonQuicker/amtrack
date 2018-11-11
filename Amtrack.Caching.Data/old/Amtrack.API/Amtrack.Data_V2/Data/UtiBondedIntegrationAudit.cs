using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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

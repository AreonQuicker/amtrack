using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WmsDocumentImportStatus
    {
        public string DocumentNumber { get; set; }
        public short DocumentVersion { get; set; }
        public bool WmsImport { get; set; }
        public DateTime WmsImportDate { get; set; }
        public bool WmsPickStarted { get; set; }
        public DateTime? WmsPickStartDate { get; set; }
        public bool WmsPickComplete { get; set; }
        public DateTime? WmsPickCompleteDate { get; set; }
    }
}

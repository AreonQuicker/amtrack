using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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

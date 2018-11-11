using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ReworkDocuments
    {
        public long FkWmsDocumentId { get; set; }
        public long FkReworkId { get; set; }

        public Rework FkRework { get; set; }
        public WmsDocuments FkWmsDocument { get; set; }
    }
}

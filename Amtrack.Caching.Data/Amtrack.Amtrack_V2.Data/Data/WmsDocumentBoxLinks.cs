using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WmsDocumentBoxLinks
    {
        public long FkWmsDocumentId { get; set; }
        public long FkWmsDocumentBoxId { get; set; }

        public WmsDocuments FkWmsDocument { get; set; }
        public WmsDocumentBoxes FkWmsDocumentBox { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WmsDocumentBoxLinks
    {
        public long FkWmsDocumentId { get; set; }
        public long FkWmsDocumentBoxId { get; set; }

        public WmsDocuments FkWmsDocument { get; set; }
        public WmsDocumentBoxes FkWmsDocumentBox { get; set; }
    }
}

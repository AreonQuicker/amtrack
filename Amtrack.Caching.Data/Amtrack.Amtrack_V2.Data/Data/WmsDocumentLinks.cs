using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WmsDocumentLinks
    {
        public long FkWmsDocumentParentId { get; set; }
        public long FkWmsDocumentId { get; set; }

        public WmsDocuments FkWmsDocument { get; set; }
        public WmsDocuments FkWmsDocumentParent { get; set; }
    }
}

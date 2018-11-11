using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WmsDocumentLinks
    {
        public long FkWmsDocumentParentId { get; set; }
        public long FkWmsDocumentId { get; set; }

        public WmsDocuments FkWmsDocument { get; set; }
        public WmsDocuments FkWmsDocumentParent { get; set; }
    }
}

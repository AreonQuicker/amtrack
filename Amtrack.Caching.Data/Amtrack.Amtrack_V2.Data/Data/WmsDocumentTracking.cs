using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WmsDocumentTracking
    {
        public long FkWmsDocumentId { get; set; }
        public long FkWmsTrackingId { get; set; }

        public WmsDocuments FkWmsDocument { get; set; }
        public WmsTracking FkWmsTracking { get; set; }
    }
}

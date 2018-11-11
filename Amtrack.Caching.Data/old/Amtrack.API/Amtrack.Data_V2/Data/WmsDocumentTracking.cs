using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WmsDocumentTracking
    {
        public long FkWmsDocumentId { get; set; }
        public long FkWmsTrackingId { get; set; }

        public WmsDocuments FkWmsDocument { get; set; }
        public WmsTracking FkWmsTracking { get; set; }
    }
}

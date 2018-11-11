using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WmsDocumentBoxTracking
    {
        public long FkWmsDocumentBoxId { get; set; }
        public long FkWmsTrackingId { get; set; }

        public WmsDocumentBoxes FkWmsDocumentBox { get; set; }
        public WmsTracking FkWmsTracking { get; set; }
    }
}

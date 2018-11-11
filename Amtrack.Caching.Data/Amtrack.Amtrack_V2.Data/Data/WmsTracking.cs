using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WmsTracking
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long? FkUserId { get; set; }
        public string FkUserName { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }

        public WmsDocumentBoxTracking WmsDocumentBoxTracking { get; set; }
        public WmsDocumentTracking WmsDocumentTracking { get; set; }
    }
}

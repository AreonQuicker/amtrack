using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WmsStagingLocationSessionBoxes
    {
        public WmsStagingLocationSessionBoxes()
        {
            WmsStagingLocationSessionTracking = new HashSet<WmsStagingLocationSessionTracking>();
        }

        public long Id { get; set; }
        public long FkWmsDocumentBoxId { get; set; }
        public long FkWmsStagingLocationSessionId { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public WmsStagingLocationSessions FkWmsStagingLocationSession { get; set; }
        public ICollection<WmsStagingLocationSessionTracking> WmsStagingLocationSessionTracking { get; set; }
    }
}

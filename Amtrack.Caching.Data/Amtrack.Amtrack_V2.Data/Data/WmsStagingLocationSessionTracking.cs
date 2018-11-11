using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WmsStagingLocationSessionTracking
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long? FkUserId { get; set; }
        public long FkWmsStagingLocationSessionId { get; set; }
        public long? FkWmsStagingLocationSessionBoxId { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }

        public WmsStagingLocationSessions FkWmsStagingLocationSession { get; set; }
        public WmsStagingLocationSessionBoxes FkWmsStagingLocationSessionBox { get; set; }
    }
}

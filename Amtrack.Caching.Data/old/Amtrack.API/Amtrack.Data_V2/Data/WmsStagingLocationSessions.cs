using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class WmsStagingLocationSessions
    {
        public WmsStagingLocationSessions()
        {
            WmsStagingLocationSessionBoxes = new HashSet<WmsStagingLocationSessionBoxes>();
            WmsStagingLocationSessionTracking = new HashSet<WmsStagingLocationSessionTracking>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkWmsStagingLocationId { get; set; }
        public int Version { get; set; }
        public long? FkFromLocationId { get; set; }
        public long FkToParentLocationId { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public WmsStagingLocations FkWmsStagingLocation { get; set; }
        public ICollection<WmsStagingLocationSessionBoxes> WmsStagingLocationSessionBoxes { get; set; }
        public ICollection<WmsStagingLocationSessionTracking> WmsStagingLocationSessionTracking { get; set; }
    }
}

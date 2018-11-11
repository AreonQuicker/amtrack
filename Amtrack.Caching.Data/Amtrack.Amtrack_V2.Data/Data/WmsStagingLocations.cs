using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WmsStagingLocations
    {
        public WmsStagingLocations()
        {
            WmsStagingLocationSessions = new HashSet<WmsStagingLocationSessions>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkLocationId { get; set; }
        public string Name { get; set; }
        public string Barcode { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ICollection<WmsStagingLocationSessions> WmsStagingLocationSessions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqLookupQueueTrackingTypes
    {
        public LqLookupQueueTrackingTypes()
        {
            LqQueueTracking = new HashSet<LqQueueTracking>();
        }

        public int Id { get; set; }
        public string TypeCode { get; set; }
        public string TypeDescription { get; set; }
        public long Flags { get; set; }

        public ICollection<LqQueueTracking> LqQueueTracking { get; set; }
    }
}

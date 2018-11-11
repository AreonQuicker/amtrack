using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqQueueTracking
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkQueueId { get; set; }
        public long? FkUserId { get; set; }
        public int FkTypeId { get; set; }
        public long Flags { get; set; }
        public int QueueRevision { get; set; }

        public LqQueue FkQueue { get; set; }
        public LqLookupQueueTrackingTypes FkType { get; set; }
        public User FkUser { get; set; }
        public LqQueueNotes LqQueueNotes { get; set; }
    }
}

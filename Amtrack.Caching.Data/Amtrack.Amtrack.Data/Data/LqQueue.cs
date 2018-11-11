using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LqQueue
    {
        public LqQueue()
        {
            LqLayoutDocuments = new HashSet<LqLayoutDocuments>();
            LqQueueTracking = new HashSet<LqQueueTracking>();
        }

        public long Id { get; set; }
        public long FkJobCardId { get; set; }
        public int Status { get; set; }
        public int Revision { get; set; }
        public long Flags { get; set; }

        public JobCard FkJobCard { get; set; }
        public ICollection<LqLayoutDocuments> LqLayoutDocuments { get; set; }
        public ICollection<LqQueueTracking> LqQueueTracking { get; set; }
    }
}

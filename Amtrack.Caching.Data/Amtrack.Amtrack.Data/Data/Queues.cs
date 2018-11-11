using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Queues
    {
        public Queues()
        {
            JobCardQueue = new HashSet<JobCardQueue>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public int Priority { get; set; }

        public PrintDepartmentQueues PrintDepartmentQueues { get; set; }
        public ICollection<JobCardQueue> JobCardQueue { get; set; }
    }
}

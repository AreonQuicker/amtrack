using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class SystemRequest
    {
        public SystemRequest()
        {
            SystemRequestAttachment = new HashSet<SystemRequestAttachment>();
            SystemRequestTracking = new HashSet<SystemRequestTracking>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long AuthorId { get; set; }
        public string Title { get; set; }
        public string Page { get; set; }
        public string Referrer { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public string Data { get; set; }

        public User Author { get; set; }
        public ICollection<SystemRequestAttachment> SystemRequestAttachment { get; set; }
        public ICollection<SystemRequestTracking> SystemRequestTracking { get; set; }
    }
}

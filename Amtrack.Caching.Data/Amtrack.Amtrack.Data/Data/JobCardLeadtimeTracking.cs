using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardLeadtimeTracking
    {
        public long Id { get; set; }
        public long FkJobCardId { get; set; }
        public DateTime Created { get; set; }
        public int? OldValue { get; set; }
        public int NewValue { get; set; }
        public string ModifiedSource { get; set; }
        public string User { get; set; }
        public string Descriptor { get; set; }

        public JobCard FkJobCard { get; set; }
    }
}

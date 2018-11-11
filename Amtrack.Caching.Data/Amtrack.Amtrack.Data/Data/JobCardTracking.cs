using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardTracking
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Tracking FkNavigation { get; set; }
        public JobCard PkNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BatchTracking
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Tracking FkNavigation { get; set; }
        public Batch PkNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardLayouts
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Layout FkNavigation { get; set; }
        public JobCard PkNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LinkLineJobCards
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public JobCard FkNavigation { get; set; }
        public Line PkNavigation { get; set; }
    }
}

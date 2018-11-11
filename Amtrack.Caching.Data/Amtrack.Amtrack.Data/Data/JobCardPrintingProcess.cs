using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardPrintingProcess
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public JobCard FkNavigation { get; set; }
        public PrintProcess PkNavigation { get; set; }
    }
}

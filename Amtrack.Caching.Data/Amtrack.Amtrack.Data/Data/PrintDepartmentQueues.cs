using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PrintDepartmentQueues
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Queues FkNavigation { get; set; }
        public PrintDepartment PkNavigation { get; set; }
    }
}

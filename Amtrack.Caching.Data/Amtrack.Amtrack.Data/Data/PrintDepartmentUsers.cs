using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PrintDepartmentUsers
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public User FkNavigation { get; set; }
        public PrintDepartment PkNavigation { get; set; }
    }
}

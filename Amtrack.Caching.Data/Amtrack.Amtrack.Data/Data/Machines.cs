using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Machines
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        public long Department { get; set; }

        public PrintDepartment DepartmentNavigation { get; set; }
    }
}

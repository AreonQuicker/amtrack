using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Departments
    {
        public Departments()
        {
            UserDepartment = new HashSet<UserDepartment>();
        }

        public Guid DepartmentId { get; set; }
        public string Name { get; set; }
        public long Flags { get; set; }

        public ICollection<UserDepartment> UserDepartment { get; set; }
    }
}

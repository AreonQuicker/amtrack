using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class UserDepartment
    {
        public Guid UsersUserId { get; set; }
        public Guid DepartmentsDepartmentId { get; set; }

        public Departments DepartmentsDepartment { get; set; }
        public Users UsersUser { get; set; }
    }
}

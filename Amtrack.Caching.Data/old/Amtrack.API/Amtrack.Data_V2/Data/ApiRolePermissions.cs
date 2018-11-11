using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ApiRolePermissions
    {
        public int FkRoleId { get; set; }
        public int FkPermissionId { get; set; }
        public int Flags { get; set; }

        public ApiPermissions FkPermission { get; set; }
        public ApiRoles FkRole { get; set; }
    }
}

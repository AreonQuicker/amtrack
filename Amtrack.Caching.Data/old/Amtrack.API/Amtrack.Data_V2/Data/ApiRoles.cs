using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ApiRoles
    {
        public ApiRoles()
        {
            ApiIntegratorRoles = new HashSet<ApiIntegratorRoles>();
            ApiRolePermissions = new HashSet<ApiRolePermissions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Flags { get; set; }

        public ICollection<ApiIntegratorRoles> ApiIntegratorRoles { get; set; }
        public ICollection<ApiRolePermissions> ApiRolePermissions { get; set; }
    }
}

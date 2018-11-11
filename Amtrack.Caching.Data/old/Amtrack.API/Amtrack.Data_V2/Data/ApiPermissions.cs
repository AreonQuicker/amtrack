using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ApiPermissions
    {
        public ApiPermissions()
        {
            ApiIntegratorPermissions = new HashSet<ApiIntegratorPermissions>();
            ApiRolePermissions = new HashSet<ApiRolePermissions>();
        }

        public int Id { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public int Flags { get; set; }

        public ICollection<ApiIntegratorPermissions> ApiIntegratorPermissions { get; set; }
        public ICollection<ApiRolePermissions> ApiRolePermissions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
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

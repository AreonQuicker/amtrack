using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ApiIntegrator
    {
        public ApiIntegrator()
        {
            ApiIntegratorImpersonations = new HashSet<ApiIntegratorImpersonations>();
            ApiIntegratorPermissions = new HashSet<ApiIntegratorPermissions>();
            ApiIntegratorRoles = new HashSet<ApiIntegratorRoles>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public string Ips { get; set; }
        public int Flags { get; set; }

        public ICollection<ApiIntegratorImpersonations> ApiIntegratorImpersonations { get; set; }
        public ICollection<ApiIntegratorPermissions> ApiIntegratorPermissions { get; set; }
        public ICollection<ApiIntegratorRoles> ApiIntegratorRoles { get; set; }
    }
}

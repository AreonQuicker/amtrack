using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ApiIntegratorPermissions
    {
        public int FkIntegratorId { get; set; }
        public int FkPermissionId { get; set; }
        public int Flags { get; set; }

        public ApiIntegrator FkIntegrator { get; set; }
        public ApiPermissions FkPermission { get; set; }
    }
}

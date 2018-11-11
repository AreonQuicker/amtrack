using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
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

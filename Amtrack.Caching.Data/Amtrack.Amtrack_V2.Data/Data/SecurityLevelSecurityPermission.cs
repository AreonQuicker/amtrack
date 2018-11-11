using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class SecurityLevelSecurityPermission
    {
        public Guid SecurityLevelsSecurityLevelId { get; set; }
        public Guid SecurityPermissionsSecurityPermissionId { get; set; }

        public SecurityLevels SecurityLevelsSecurityLevel { get; set; }
        public SecurityPermissions SecurityPermissionsSecurityPermission { get; set; }
    }
}

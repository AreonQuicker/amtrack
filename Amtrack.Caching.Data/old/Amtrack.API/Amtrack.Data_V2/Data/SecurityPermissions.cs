using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class SecurityPermissions
    {
        public SecurityPermissions()
        {
            SecurityLevelSecurityPermission = new HashSet<SecurityLevelSecurityPermission>();
            UserSecurityPermission = new HashSet<UserSecurityPermission>();
        }

        public Guid SecurityPermissionId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }

        public ICollection<SecurityLevelSecurityPermission> SecurityLevelSecurityPermission { get; set; }
        public ICollection<UserSecurityPermission> UserSecurityPermission { get; set; }
    }
}

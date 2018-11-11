using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class UserSecurityPermission
    {
        public Guid UsersUserId { get; set; }
        public Guid SecurityPermissionsSecurityPermissionId { get; set; }

        public SecurityPermissions SecurityPermissionsSecurityPermission { get; set; }
        public Users UsersUser { get; set; }
    }
}

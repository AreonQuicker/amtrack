using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class SecurityLevels
    {
        public SecurityLevels()
        {
            SecurityLevelSecurityPermission = new HashSet<SecurityLevelSecurityPermission>();
            Users = new HashSet<Users>();
        }

        public Guid SecurityLevelId { get; set; }
        public string Name { get; set; }

        public ICollection<SecurityLevelSecurityPermission> SecurityLevelSecurityPermission { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}

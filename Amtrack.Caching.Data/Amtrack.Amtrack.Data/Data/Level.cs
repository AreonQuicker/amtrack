using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Level
    {
        public Level()
        {
            PermissionMatrix = new HashSet<PermissionMatrix>();
            SecurityLevels = new HashSet<SecurityLevels>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Name { get; set; }

        public ICollection<PermissionMatrix> PermissionMatrix { get; set; }
        public ICollection<SecurityLevels> SecurityLevels { get; set; }
    }
}

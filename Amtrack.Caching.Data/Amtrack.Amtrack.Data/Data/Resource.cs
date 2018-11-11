﻿using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Resource
    {
        public Resource()
        {
            ResourcePermissions = new HashSet<ResourcePermissions>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }

        public ICollection<ResourcePermissions> ResourcePermissions { get; set; }
    }
}

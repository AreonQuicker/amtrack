using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ResourcePermissions
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Permission FkNavigation { get; set; }
        public Resource PkNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PermissionMatrix
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Permission FkNavigation { get; set; }
        public Level PkNavigation { get; set; }
    }
}

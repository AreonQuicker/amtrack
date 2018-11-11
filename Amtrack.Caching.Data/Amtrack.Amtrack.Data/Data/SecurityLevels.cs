using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class SecurityLevels
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public User FkNavigation { get; set; }
        public Level PkNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LayoutTracking
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Tracking FkNavigation { get; set; }
        public Layout PkNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LocationItems
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Order FkNavigation { get; set; }
        public Location PkNavigation { get; set; }
    }
}

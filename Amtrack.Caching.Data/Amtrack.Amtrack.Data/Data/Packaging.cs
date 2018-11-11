using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Packaging
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Parcel FkNavigation { get; set; }
        public Order PkNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LayoutArtists
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Layout FkNavigation { get; set; }
        public User PkNavigation { get; set; }
    }
}

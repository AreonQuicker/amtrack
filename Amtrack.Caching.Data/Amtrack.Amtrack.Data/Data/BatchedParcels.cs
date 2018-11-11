using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BatchedParcels
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Parcel FkNavigation { get; set; }
        public Batch PkNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ReturnedBatchDetail
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public ReturnedLine FkNavigation { get; set; }
        public Batch PkNavigation { get; set; }
    }
}

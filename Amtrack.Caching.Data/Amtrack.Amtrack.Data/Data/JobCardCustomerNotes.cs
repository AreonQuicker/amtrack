using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardCustomerNotes
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public Note FkNavigation { get; set; }
        public JobCard PkNavigation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardAttachments
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public JobCardAttachment FkNavigation { get; set; }
        public JobCard PkNavigation { get; set; }
    }
}

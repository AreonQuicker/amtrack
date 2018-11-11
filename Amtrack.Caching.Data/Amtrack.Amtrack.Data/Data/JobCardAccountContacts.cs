using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardAccountContacts
    {
        public long JobCardFk { get; set; }
        public long AccountContactFk { get; set; }

        public AccountContacts AccountContactFkNavigation { get; set; }
        public JobCard JobCardFkNavigation { get; set; }
    }
}

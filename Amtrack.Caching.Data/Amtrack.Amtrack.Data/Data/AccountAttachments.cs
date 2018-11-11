using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AccountAttachments
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public AccountAttachment FkNavigation { get; set; }
        public Account PkNavigation { get; set; }
    }
}

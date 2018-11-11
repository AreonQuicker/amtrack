using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AccountContactNotifications
    {
        public long Pk { get; set; }
        public long Fk { get; set; }

        public AccountNotifications FkNavigation { get; set; }
        public AccountContacts PkNavigation { get; set; }
    }
}

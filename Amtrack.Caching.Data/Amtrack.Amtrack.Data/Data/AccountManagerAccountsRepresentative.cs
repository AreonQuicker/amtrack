using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AccountManagerAccountsRepresentative
    {
        public long AccountManagerId { get; set; }
        public long AccountsUserId { get; set; }

        public User AccountManager { get; set; }
        public User AccountsUser { get; set; }
    }
}

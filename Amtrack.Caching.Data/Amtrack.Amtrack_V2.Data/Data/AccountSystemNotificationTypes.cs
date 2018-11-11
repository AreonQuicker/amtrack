using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AccountSystemNotificationTypes
    {
        public AccountSystemNotificationTypes()
        {
            AccountContactNotifications = new HashSet<AccountContactNotifications>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }

        public ICollection<AccountContactNotifications> AccountContactNotifications { get; set; }
    }
}

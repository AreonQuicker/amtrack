using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AccountNotifications
    {
        public AccountNotifications()
        {
            AccountContactNotifications = new HashSet<AccountContactNotifications>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Displayname { get; set; }

        public ICollection<AccountContactNotifications> AccountContactNotifications { get; set; }
    }
}

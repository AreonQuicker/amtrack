using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AccountContacts
    {
        public AccountContacts()
        {
            AccountContactNotifications = new HashSet<AccountContactNotifications>();
            JobCardAccountContacts = new HashSet<JobCardAccountContacts>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public long AccountId { get; set; }
        public int Flags { get; set; }

        public Account Account { get; set; }
        public ICollection<AccountContactNotifications> AccountContactNotifications { get; set; }
        public ICollection<JobCardAccountContacts> JobCardAccountContacts { get; set; }
    }
}

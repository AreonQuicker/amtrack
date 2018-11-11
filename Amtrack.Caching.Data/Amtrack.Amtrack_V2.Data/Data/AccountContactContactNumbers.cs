using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AccountContactContactNumbers
    {
        public int Id { get; set; }
        public int FkAccountContactId { get; set; }
        public int FkContactNumberId { get; set; }
        public int Flags { get; set; }

        public AccountContacts FkAccountContact { get; set; }
        public ContactNumbers FkContactNumber { get; set; }
    }
}

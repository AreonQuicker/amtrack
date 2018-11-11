using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AccountContactNumbers
    {
        public int Id { get; set; }
        public int FkAccountId { get; set; }
        public int FkContactNumberId { get; set; }
        public int Flags { get; set; }

        public Accounts FkAccount { get; set; }
        public ContactNumbers FkContactNumber { get; set; }
    }
}

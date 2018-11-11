using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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

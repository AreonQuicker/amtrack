using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AccountCreditLimit
    {
        public long AccountFk { get; set; }
        public DateTime Created { get; set; }
        public DateTime ExpireDate { get; set; }
        public double CredtiLimit { get; set; }
        public long Flags { get; set; }

        public Account AccountFkNavigation { get; set; }
    }
}

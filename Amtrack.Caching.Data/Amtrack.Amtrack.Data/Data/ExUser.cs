using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ExUser
    {
        public long UserId { get; set; }
        public string Department { get; set; }
        public string PastelCode { get; set; }

        public User User { get; set; }
    }
}

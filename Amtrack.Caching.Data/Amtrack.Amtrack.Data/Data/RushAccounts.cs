using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class RushAccounts
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkAccount { get; set; }
        public long XfkCustomerId { get; set; }
        public string WebCustomerFirstName { get; set; }
        public string WebCustomerLastName { get; set; }
        public string WebCustomerEmail { get; set; }
        public string AccessToken { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }

        public Account FkAccountNavigation { get; set; }
    }
}

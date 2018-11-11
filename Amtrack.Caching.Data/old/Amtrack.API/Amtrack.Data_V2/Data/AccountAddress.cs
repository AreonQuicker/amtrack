using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AccountAddress
    {
        public int Id { get; set; }
        public int FkAccountId { get; set; }
        public int FkAddressId { get; set; }
        public int Flags { get; set; }
        public string AddressName { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }

        public Accounts FkAccount { get; set; }
        public Addresses FkAddress { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AccountContactAddress
    {
        public long Id { get; set; }
        public int FkAccountContactId { get; set; }
        public int FkAddressId { get; set; }
        public int Flags { get; set; }
        public string AddressName { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }

        public AccountContacts FkAccountContact { get; set; }
        public Addresses FkAddress { get; set; }
    }
}

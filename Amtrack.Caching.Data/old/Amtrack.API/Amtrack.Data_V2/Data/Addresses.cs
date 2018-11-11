using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Addresses
    {
        public Addresses()
        {
            AccountAddress = new HashSet<AccountAddress>();
            AccountContactAddress = new HashSet<AccountContactAddress>();
            BranchAddresses = new HashSet<BranchAddresses>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public short Type { get; set; }
        public string UnitNumber { get; set; }
        public string OfficePark { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public int Flags { get; set; }
        public int? XfxHostId { get; set; }
        public string City { get; set; }
        public string CompanyName { get; set; }

        public ICollection<AccountAddress> AccountAddress { get; set; }
        public ICollection<AccountContactAddress> AccountContactAddress { get; set; }
        public ICollection<BranchAddresses> BranchAddresses { get; set; }
    }
}

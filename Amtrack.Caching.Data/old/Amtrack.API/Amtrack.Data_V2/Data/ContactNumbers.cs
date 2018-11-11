using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ContactNumbers
    {
        public ContactNumbers()
        {
            AccountContactContactNumbers = new HashSet<AccountContactContactNumbers>();
            AccountContactNumbers = new HashSet<AccountContactNumbers>();
            BranchContactNumbers = new HashSet<BranchContactNumbers>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string RegionCode { get; set; }
        public string CountryCode { get; set; }
        public short Type { get; set; }
        public int Flags { get; set; }

        public ICollection<AccountContactContactNumbers> AccountContactContactNumbers { get; set; }
        public ICollection<AccountContactNumbers> AccountContactNumbers { get; set; }
        public ICollection<BranchContactNumbers> BranchContactNumbers { get; set; }
    }
}

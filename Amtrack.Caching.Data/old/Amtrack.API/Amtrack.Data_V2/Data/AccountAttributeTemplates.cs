using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AccountAttributeTemplates
    {
        public AccountAttributeTemplates()
        {
            AccountAttributes = new HashSet<AccountAttributes>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Section { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public int Flags { get; set; }

        public ICollection<AccountAttributes> AccountAttributes { get; set; }
    }
}

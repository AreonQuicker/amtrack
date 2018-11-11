using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Customer
    {
        public Customer()
        {
            CustomerQuotes = new HashSet<CustomerQuotes>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public int Status { get; set; }

        public AccountCustomers AccountCustomers { get; set; }
        public ICollection<CustomerQuotes> CustomerQuotes { get; set; }
    }
}

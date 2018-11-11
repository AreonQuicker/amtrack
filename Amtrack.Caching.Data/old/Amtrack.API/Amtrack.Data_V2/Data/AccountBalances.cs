using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AccountBalances
    {
        public AccountBalances()
        {
            Accounts = new HashSet<Accounts>();
        }

        public int Id { get; set; }
        public double CreditLimit { get; set; }
        public double? EnhancedCreditLimit { get; set; }
        public DateTime? EnhancedExpiryDate { get; set; }
        public double TotalBalance { get; set; }
        public double BatchedBalance { get; set; }
        public double UnBatchedBalance { get; set; }
        public int Flags { get; set; }

        public ICollection<Accounts> Accounts { get; set; }
    }
}

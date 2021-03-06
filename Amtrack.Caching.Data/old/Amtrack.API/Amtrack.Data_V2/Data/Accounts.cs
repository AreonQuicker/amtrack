﻿using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Accounts
    {
        public Accounts()
        {
            AccountAddress = new HashSet<AccountAddress>();
            AccountAttributes = new HashSet<AccountAttributes>();
            AccountContactNumbers = new HashSet<AccountContactNumbers>();
            AccountContacts = new HashSet<AccountContacts>();
            InverseFkMasterAccount = new HashSet<Accounts>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid? FkAccountManagerId { get; set; }
        public int? FkMasterAccountId { get; set; }
        public int FkTaxRateId { get; set; }
        public int FkPricelistId { get; set; }
        public int FkAccountBalanceId { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string WebAddress { get; set; }
        public short PaymentType { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public int Flags { get; set; }
        public int? XfxHostId { get; set; }

        public AccountBalances FkAccountBalance { get; set; }
        public Users FkAccountManager { get; set; }
        public Accounts FkMasterAccount { get; set; }
        public TaxRates FkTaxRate { get; set; }
        public AccountCreditLimitSettings AccountCreditLimitSettings { get; set; }
        public ICollection<AccountAddress> AccountAddress { get; set; }
        public ICollection<AccountAttributes> AccountAttributes { get; set; }
        public ICollection<AccountContactNumbers> AccountContactNumbers { get; set; }
        public ICollection<AccountContacts> AccountContacts { get; set; }
        public ICollection<Accounts> InverseFkMasterAccount { get; set; }
    }
}

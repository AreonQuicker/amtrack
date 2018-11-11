using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Branches
    {
        public Branches()
        {
            BranchAddresses = new HashSet<BranchAddresses>();
            BranchAlps = new HashSet<BranchAlps>();
            BranchAttributes = new HashSet<BranchAttributes>();
            BranchContactNumbers = new HashSet<BranchContactNumbers>();
            BranchInvoiceTypeFkBranch = new HashSet<BranchInvoiceType>();
            BranchInvoiceTypeFkPrimaryBranch = new HashSet<BranchInvoiceType>();
            BranchInvoiceTypeFkSecondaryBranch = new HashSet<BranchInvoiceType>();
            BranchServers = new HashSet<BranchServers>();
            BranchSetting = new HashSet<BranchSetting>();
            BranchWarehouseLink = new HashSet<BranchWarehouseLink>();
            BranchWifi = new HashSet<BranchWifi>();
            Printers = new HashSet<Printers>();
            UserBranches = new HashSet<UserBranches>();
        }

        public long Id { get; set; }
        public string BranchName { get; set; }
        public int Type { get; set; }
        public string Prefix { get; set; }
        public string InFolder { get; set; }
        public string OutFolder { get; set; }
        public string CompanyName { get; set; }
        public string TradingName { get; set; }
        public string VatNumber { get; set; }
        public string RegNumber { get; set; }
        public string Status { get; set; }
        public int? FkCurrencyId { get; set; }
        public string CompanyCode { get; set; }
        public string BranchCode { get; set; }
        public int Flags { get; set; }

        public Currency FkCurrency { get; set; }
        public ICollection<BranchAddresses> BranchAddresses { get; set; }
        public ICollection<BranchAlps> BranchAlps { get; set; }
        public ICollection<BranchAttributes> BranchAttributes { get; set; }
        public ICollection<BranchContactNumbers> BranchContactNumbers { get; set; }
        public ICollection<BranchInvoiceType> BranchInvoiceTypeFkBranch { get; set; }
        public ICollection<BranchInvoiceType> BranchInvoiceTypeFkPrimaryBranch { get; set; }
        public ICollection<BranchInvoiceType> BranchInvoiceTypeFkSecondaryBranch { get; set; }
        public ICollection<BranchServers> BranchServers { get; set; }
        public ICollection<BranchSetting> BranchSetting { get; set; }
        public ICollection<BranchWarehouseLink> BranchWarehouseLink { get; set; }
        public ICollection<BranchWifi> BranchWifi { get; set; }
        public ICollection<Printers> Printers { get; set; }
        public ICollection<UserBranches> UserBranches { get; set; }
    }
}

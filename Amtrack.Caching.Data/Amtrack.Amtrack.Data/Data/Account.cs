using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Account
    {
        public Account()
        {
            AccountAttachments = new HashSet<AccountAttachments>();
            AccountContacts = new HashSet<AccountContacts>();
            AccountCustomers = new HashSet<AccountCustomers>();
            AccountNotes = new HashSet<AccountNotes>();
            AccountOrders = new HashSet<AccountOrders>();
            AccountQuotes = new HashSet<AccountQuotes>();
            CreditNoteAccount = new HashSet<CreditNoteAccount>();
            DeliveryRequest = new HashSet<DeliveryRequest>();
            EmbroideryQuoteRequest = new HashSet<EmbroideryQuoteRequest>();
            LinkedReturnStock = new HashSet<LinkedReturnStock>();
            RushAccounts = new HashSet<RushAccounts>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string PostalAddress { get; set; }
        public string PostalCode { get; set; }
        public string PhysicalAddress { get; set; }
        public string PhysicalCode { get; set; }
        public string Website { get; set; }
        public int Status { get; set; }
        public bool IsBlockingEmails { get; set; }
        public bool IsBlockingSms { get; set; }
        public int? Type { get; set; }
        public bool SendToAccManager { get; set; }
        public string ContactPerson { get; set; }
        public string AccManager { get; set; }
        public bool? IsBlockingBranchDelivery { get; set; }
        public string VatNumber { get; set; }
        public string BranchCode { get; set; }
        public long? ParentAccountId { get; set; }
        public string DeferVatnumber { get; set; }

        public AccountCreditLimit AccountCreditLimit { get; set; }
        public AccountCreditLimitGroups AccountCreditLimitGroups { get; set; }
        public ICollection<AccountAttachments> AccountAttachments { get; set; }
        public ICollection<AccountContacts> AccountContacts { get; set; }
        public ICollection<AccountCustomers> AccountCustomers { get; set; }
        public ICollection<AccountNotes> AccountNotes { get; set; }
        public ICollection<AccountOrders> AccountOrders { get; set; }
        public ICollection<AccountQuotes> AccountQuotes { get; set; }
        public ICollection<CreditNoteAccount> CreditNoteAccount { get; set; }
        public ICollection<DeliveryRequest> DeliveryRequest { get; set; }
        public ICollection<EmbroideryQuoteRequest> EmbroideryQuoteRequest { get; set; }
        public ICollection<LinkedReturnStock> LinkedReturnStock { get; set; }
        public ICollection<RushAccounts> RushAccounts { get; set; }
    }
}

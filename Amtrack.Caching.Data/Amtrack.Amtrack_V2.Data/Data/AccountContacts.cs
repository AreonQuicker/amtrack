using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AccountContacts
    {
        public AccountContacts()
        {
            AccountContactAddress = new HashSet<AccountContactAddress>();
            AccountContactContactNumbers = new HashSet<AccountContactContactNumbers>();
            AccountContactNotifications = new HashSet<AccountContactNotifications>();
            BrandingLineInfoContacts = new HashSet<BrandingLineInfoContacts>();
            DeliveryWaybill = new HashSet<DeliveryWaybill>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int FkAccountId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int Flags { get; set; }

        public Accounts FkAccount { get; set; }
        public ICollection<AccountContactAddress> AccountContactAddress { get; set; }
        public ICollection<AccountContactContactNumbers> AccountContactContactNumbers { get; set; }
        public ICollection<AccountContactNotifications> AccountContactNotifications { get; set; }
        public ICollection<BrandingLineInfoContacts> BrandingLineInfoContacts { get; set; }
        public ICollection<DeliveryWaybill> DeliveryWaybill { get; set; }
    }
}

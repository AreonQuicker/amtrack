using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AdtAccount
    {
        public long Aid { get; set; }
        public DateTime Actiondate { get; set; }
        public short Action { get; set; }
        public long Id { get; set; }
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
    }
}

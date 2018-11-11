using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DeliveryAddress
    {
        public DeliveryAddress()
        {
            DeliveryQuote = new HashSet<DeliveryQuote>();
            DeliveryWaybill = new HashSet<DeliveryWaybill>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string UnitNumber { get; set; }
        public string OfficePark { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
        public string City { get; set; }
        public int? FkAddressId { get; set; }
        public string CompanyName { get; set; }

        public ICollection<DeliveryQuote> DeliveryQuote { get; set; }
        public ICollection<DeliveryWaybill> DeliveryWaybill { get; set; }
    }
}

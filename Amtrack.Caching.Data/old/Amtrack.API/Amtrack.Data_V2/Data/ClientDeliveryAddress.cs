using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ClientDeliveryAddress
    {
        public ClientDeliveryAddress()
        {
            ClientDelivery = new HashSet<ClientDelivery>();
        }

        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string OfficeBuilding { get; set; }
        public string SuiteNo { get; set; }
        public string Suburb { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public string BranchCode { get; set; }
        public string FriendlyName { get; set; }

        public ICollection<ClientDelivery> ClientDelivery { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DeliverySuburbLookup
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkProviderId { get; set; }
        public string PostalCode { get; set; }
        public string Suburb { get; set; }
        public int Flags { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string Zone { get; set; }

        public DeliveryProvider FkProvider { get; set; }
    }
}

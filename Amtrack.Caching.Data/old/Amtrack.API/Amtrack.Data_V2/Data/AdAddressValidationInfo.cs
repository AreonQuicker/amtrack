using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AdAddressValidationInfo
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string State { get; set; }
        public string Locale { get; set; }
        public string Use { get; set; }
    }
}

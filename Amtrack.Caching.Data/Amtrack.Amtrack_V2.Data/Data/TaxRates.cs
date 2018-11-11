using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class TaxRates
    {
        public TaxRates()
        {
            Accounts = new HashSet<Accounts>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string CompanyCode { get; set; }
        public string PastelLookup { get; set; }
        public double Rate { get; set; }
        public int Flags { get; set; }
        public int? XfxHostId { get; set; }

        public ICollection<Accounts> Accounts { get; set; }
    }
}

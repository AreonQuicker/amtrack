using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Quote
    {
        public Quote()
        {
            QuoteItems = new HashSet<QuoteItems>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string QuoteStatus { get; set; }
        public string QuoteNotes { get; set; }
        public string Number { get; set; }
        public double TotalExclVat { get; set; }
        public double TotalInclVat { get; set; }
        public double Vat { get; set; }

        public AccountQuotes AccountQuotes { get; set; }
        public CustomerQuotes CustomerQuotes { get; set; }
        public ICollection<QuoteItems> QuoteItems { get; set; }
    }
}

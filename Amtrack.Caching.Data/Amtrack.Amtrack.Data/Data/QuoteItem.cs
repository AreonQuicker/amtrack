using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class QuoteItem
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Description { get; set; }
        public string ItemCode { get; set; }
        public int Qty { get; set; }
        public double UnitPriceExclVat { get; set; }
        public double AmountInclVat { get; set; }
        public double Vat { get; set; }
        public int LineNumber { get; set; }
        public double Unit { get; set; }

        public QuoteItems QuoteItems { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockPricelists
    {
        public StockPricelists()
        {
            StockEmbroideryPricing = new HashSet<StockEmbroideryPricing>();
            StockItemPriceMatrix = new HashSet<StockItemPriceMatrix>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Modified { get; set; }
        public string CompanyCode { get; set; }
        public string DisplayName { get; set; }
        public string PastelLookup { get; set; }
        public int DisplayIndex { get; set; }
        public string CurrencyName { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
        public string DisplayFormat { get; set; }
        public int Flags { get; set; }
        public int? XfxHostId { get; set; }

        public ICollection<StockEmbroideryPricing> StockEmbroideryPricing { get; set; }
        public ICollection<StockItemPriceMatrix> StockItemPriceMatrix { get; set; }
    }
}

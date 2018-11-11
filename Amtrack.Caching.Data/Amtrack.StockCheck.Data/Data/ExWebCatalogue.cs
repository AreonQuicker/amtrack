using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class ExWebCatalogue
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Behavior { get; set; }
        public int Promotion { get; set; }
        public string CompanyCode { get; set; }
    }
}

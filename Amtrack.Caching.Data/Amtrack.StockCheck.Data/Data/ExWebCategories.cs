using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class ExWebCategories
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public int? FkParentId { get; set; }
        public int RelativePosition { get; set; }
        public string CompanyCode { get; set; }
    }
}

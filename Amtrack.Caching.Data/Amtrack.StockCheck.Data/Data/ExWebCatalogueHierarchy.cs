using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class ExWebCatalogueHierarchy
    {
        public long FkProductId { get; set; }
        public long FkCategoryId { get; set; }
        public string CompanyCode { get; set; }
    }
}

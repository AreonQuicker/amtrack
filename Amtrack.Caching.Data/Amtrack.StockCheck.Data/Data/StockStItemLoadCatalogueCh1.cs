using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockStItemLoadCatalogueCh1
    {
        public int FkItemId { get; set; }
        public bool WarehouseHighValue { get; set; }
        public bool WarehouseWarehouseItem { get; set; }
        public bool WarehouseDangerousGoods { get; set; }
        public bool InvoicingVisible { get; set; }
        public bool QuotesVisible { get; set; }
        public bool InvoicingSampleShopQuantityException { get; set; }
        public string CatalogueAlpcategory { get; set; }
        public bool CatalogueOnPromotion { get; set; }
    }
}

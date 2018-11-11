using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockStockGpe
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public long FkPrintDepartmentId { get; set; }
        public int NumberOfColours { get; set; }
        public int? MinQty { get; set; }
    }
}

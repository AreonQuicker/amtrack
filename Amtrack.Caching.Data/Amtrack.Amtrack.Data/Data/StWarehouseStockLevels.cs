using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StWarehouseStockLevels
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string WarehouseCode { get; set; }
        public int Skucount { get; set; }
        public double Value { get; set; }
    }
}

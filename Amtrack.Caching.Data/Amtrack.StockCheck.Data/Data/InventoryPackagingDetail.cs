using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class InventoryPackagingDetail
    {
        public string ItemCode { get; set; }
        public int QuantityperCarton { get; set; }
        public string CartonDimension { get; set; }
        public double CartonWeight { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StInventoryCategorySales
    {
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public int InventoryType { get; set; }
        public int Units { get; set; }
        public double Sales { get; set; }
    }
}

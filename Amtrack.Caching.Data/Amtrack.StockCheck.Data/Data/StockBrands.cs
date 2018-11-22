using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockBrands
    {
        public StockBrands()
        {
            StockItemBrandMatrix = new HashSet<StockItemBrandMatrix>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public int Flags { get; set; }

        public ICollection<StockItemBrandMatrix> StockItemBrandMatrix { get; set; }
    }
}

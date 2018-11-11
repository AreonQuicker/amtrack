using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemUom
    {
        public StockItemUom()
        {
            StockItemUomvalues = new HashSet<StockItemUomvalues>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int FkItemId { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public int Flags { get; set; }

        public StockItemMaster FkItem { get; set; }
        public ICollection<StockItemUomvalues> StockItemUomvalues { get; set; }
    }
}

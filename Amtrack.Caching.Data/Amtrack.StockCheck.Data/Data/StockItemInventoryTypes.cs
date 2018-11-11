using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemInventoryTypes
    {
        public StockItemInventoryTypes()
        {
            StockItemMaster = new HashSet<StockItemMaster>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public int Flags { get; set; }

        public ICollection<StockItemMaster> StockItemMaster { get; set; }
    }
}

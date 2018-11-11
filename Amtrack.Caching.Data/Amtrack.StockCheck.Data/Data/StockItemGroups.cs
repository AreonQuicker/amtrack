using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemGroups
    {
        public StockItemGroups()
        {
            StockItemGroupAttributes = new HashSet<StockItemGroupAttributes>();
            StockItemMaster = new HashSet<StockItemMaster>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }

        public ICollection<StockItemGroupAttributes> StockItemGroupAttributes { get; set; }
        public ICollection<StockItemMaster> StockItemMaster { get; set; }
    }
}

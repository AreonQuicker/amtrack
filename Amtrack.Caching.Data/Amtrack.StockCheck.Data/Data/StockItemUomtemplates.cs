using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemUomtemplates
    {
        public StockItemUomtemplates()
        {
            StockItemUomvalues = new HashSet<StockItemUomvalues>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public int Sequence { get; set; }
        public int Flags { get; set; }

        public ICollection<StockItemUomvalues> StockItemUomvalues { get; set; }
    }
}

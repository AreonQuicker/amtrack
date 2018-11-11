using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemGroupAttributeTemplates
    {
        public StockItemGroupAttributeTemplates()
        {
            StockItemGroupAttributes = new HashSet<StockItemGroupAttributes>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Section { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public int Flags { get; set; }

        public ICollection<StockItemGroupAttributes> StockItemGroupAttributes { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemAttributeTemplates
    {
        public StockItemAttributeTemplates()
        {
            StockItemAttributeTemplateOptionValues = new HashSet<StockItemAttributeTemplateOptionValues>();
            StockItemAttributes = new HashSet<StockItemAttributes>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Section { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public int Flags { get; set; }
        public int IsCatalogue { get; set; }

        public ICollection<StockItemAttributeTemplateOptionValues> StockItemAttributeTemplateOptionValues { get; set; }
        public ICollection<StockItemAttributes> StockItemAttributes { get; set; }
    }
}

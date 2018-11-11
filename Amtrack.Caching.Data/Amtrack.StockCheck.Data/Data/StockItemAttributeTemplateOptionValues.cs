using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemAttributeTemplateOptionValues
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkTemplateId { get; set; }
        public int Sequence { get; set; }
        public string Display { get; set; }
        public string Value { get; set; }

        public StockItemAttributeTemplates FkTemplate { get; set; }
    }
}

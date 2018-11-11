using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemGroupAttributes
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int FkItemGroupId { get; set; }
        public int FkAttributeTemplateId { get; set; }
        public long? NumericValue { get; set; }
        public string StringValue { get; set; }
        public double? FloatValue { get; set; }
        public bool? BoolValue { get; set; }
        public string TextValue { get; set; }
        public int Flags { get; set; }

        public StockItemGroupAttributeTemplates FkAttributeTemplate { get; set; }
        public StockItemGroups FkItemGroup { get; set; }
    }
}

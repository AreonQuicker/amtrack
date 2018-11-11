using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class StockItemAttributes
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int FkItemId { get; set; }
        public int FkAttributeTemplateId { get; set; }
        public long? NumericValue { get; set; }
        public string StringValue { get; set; }
        public double? FloatValue { get; set; }
        public bool? BoolValue { get; set; }
        public string TextValue { get; set; }
        public int Flags { get; set; }

        public StockItemAttributeTemplates FkAttributeTemplate { get; set; }
        public StockItemMaster FkItem { get; set; }
    }
}

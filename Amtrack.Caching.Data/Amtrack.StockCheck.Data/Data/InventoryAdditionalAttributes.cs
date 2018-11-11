using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class InventoryAdditionalAttributes
    {
        public string ItemCode { get; set; }
        public DateTime SyncDate { get; set; }
        public string AttribureName { get; set; }
        public string ProductAttributeSize { get; set; }
        public string AttributeValue { get; set; }
        public string AttributeValueText { get; set; }
        public int Flags { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class InventoryClasification
    {
        public string ItemCode { get; set; }
        public byte ItemType { get; set; }
        public int IdentificationTags { get; set; }
    }
}

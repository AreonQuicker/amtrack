using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class InvoicingSpecials
    {
        public int SpecialId { get; set; }
        public DateTime Created { get; set; }
        public string ItemCode { get; set; }
        public int? SpecialLimitQuantity { get; set; }
        public double? SpecialDiscount { get; set; }
        public string SpecialWarehouse { get; set; }
        public int? FixedQuantity { get; set; }
        public bool FixedPrice { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public string SpecialDiscountProject { get; set; }
        public long Flags { get; set; }
    }
}

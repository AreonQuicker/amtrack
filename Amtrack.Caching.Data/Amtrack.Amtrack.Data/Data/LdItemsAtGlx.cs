using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LdItemsAtGlx
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long? UserId { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public int? Type { get; set; }
        public int Status { get; set; }
        public long Flags { get; set; }
        public int? FkBasket { get; set; }
        public int AdjustmentType { get; set; }
    }
}

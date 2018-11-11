using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class PromotionItems
    {
        public long PromotionId { get; set; }
        public string ItemCode { get; set; }
        public bool? IsPromotion { get; set; }
    }
}

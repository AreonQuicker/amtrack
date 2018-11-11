using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BasketSessionTrackings
    {
        public long BasketSessionTrackingId { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public long? UserId { get; set; }
        public int FkBasketSessionId { get; set; }
        public int? FkBasketSessionItemId { get; set; }
        public int Type { get; set; }

        public BasketSessions FkBasketSession { get; set; }
        public BasketSessionItems FkBasketSessionItem { get; set; }
    }
}

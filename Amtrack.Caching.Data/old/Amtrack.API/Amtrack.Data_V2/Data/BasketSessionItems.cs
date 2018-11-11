using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BasketSessionItems
    {
        public BasketSessionItems()
        {
            BasketSessionTrackings = new HashSet<BasketSessionTrackings>();
        }

        public int BasketSessionItemsId { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public long Flags { get; set; }
        public short Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public string OrderNumber { get; set; }
        public string CreditNumber { get; set; }
        public long? CreatedUserId { get; set; }
        public int FkBasketSessionId { get; set; }
        public long? ClosedUserId { get; set; }
        public DateTime? ClosedDate { get; set; }
        public long? OpenUserId { get; set; }
        public DateTime? OpenDate { get; set; }
        public string BoxBarcode { get; set; }

        public BasketSessions FkBasketSession { get; set; }
        public ICollection<BasketSessionTrackings> BasketSessionTrackings { get; set; }
    }
}

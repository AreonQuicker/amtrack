using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BasketSessions
    {
        public BasketSessions()
        {
            BasketSessionItems = new HashSet<BasketSessionItems>();
            BasketSessionTrackings = new HashSet<BasketSessionTrackings>();
        }

        public int BasketSessionId { get; set; }
        public int Version { get; set; }
        public int Level { get; set; }
        public long Flags { get; set; }
        public short Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? CreatedUserId { get; set; }
        public int FkBasketId { get; set; }
        public long? ClosedUserId { get; set; }
        public DateTime? ClosedDate { get; set; }
        public long? OpenUserId { get; set; }
        public DateTime? OpenDate { get; set; }
        public long? LocationId { get; set; }
        public string LocationName { get; set; }

        public Baskets FkBasket { get; set; }
        public ICollection<BasketSessionItems> BasketSessionItems { get; set; }
        public ICollection<BasketSessionTrackings> BasketSessionTrackings { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Baskets
    {
        public Baskets()
        {
            BasketSessions = new HashSet<BasketSessions>();
            InverseFkBasket = new HashSet<Baskets>();
        }

        public int BasketId { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string FromBranchCode { get; set; }
        public string BranchCode { get; set; }
        public string Barcode { get; set; }
        public short Status { get; set; }
        public long Flags { get; set; }
        public DateTime Created { get; set; }
        public int? FkBasketId { get; set; }

        public Baskets FkBasket { get; set; }
        public ICollection<BasketSessions> BasketSessions { get; set; }
        public ICollection<Baskets> InverseFkBasket { get; set; }
    }
}

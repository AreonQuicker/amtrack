using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class IncomingEtacache
    {
        public Guid DocLineId { get; set; }
        public string Ponumber { get; set; }
        public string SubPonumber { get; set; }
        public string ItemCode { get; set; }
        public DateTime Etacurrent { get; set; }
        public DateTime? Etaprevious { get; set; }
        public DateTime? Etanotification { get; set; }
    }
}

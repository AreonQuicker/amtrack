using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class EmbroideryQuoteRequestPositionDetail
    {
        public long EmbroideryRequestId { get; set; }
        public int PositionNo { get; set; }
        public string Logo { get; set; }
        public int LogoWidth { get; set; }
        public int LogoHeight { get; set; }
        public string Position { get; set; }
        public string RepeatJob { get; set; }
        public string Colours { get; set; }
        public string StockToBrand { get; set; }
        public int Quantity { get; set; }

        public EmbroideryQuoteRequest EmbroideryRequest { get; set; }
    }
}

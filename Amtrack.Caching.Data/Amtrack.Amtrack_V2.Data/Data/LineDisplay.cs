using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class LineDisplay
    {
        public LineDisplay()
        {
            LineDisplayComponents = new HashSet<LineDisplayComponents>();
            LineDisplayPartDetails = new HashSet<LineDisplayPartDetails>();
            LineLinks = new HashSet<LineLinks>();
        }

        public int DisplayLineId { get; set; }
        public int Type { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double UnitPriceExcl { get; set; }
        public double UnitPriceIncl { get; set; }
        public double UnitTax { get; set; }
        public double LineTotalExcl { get; set; }
        public double LineTotalIncl { get; set; }
        public double LineTax { get; set; }
        public short RowNumber { get; set; }
        public Guid DocumentId { get; set; }
        public string Comments { get; set; }
        public long Flags { get; set; }
        public string ItemCodeOriginal { get; set; }

        public Documents Document { get; set; }
        public ICollection<LineDisplayComponents> LineDisplayComponents { get; set; }
        public ICollection<LineDisplayPartDetails> LineDisplayPartDetails { get; set; }
        public ICollection<LineLinks> LineLinks { get; set; }
    }
}

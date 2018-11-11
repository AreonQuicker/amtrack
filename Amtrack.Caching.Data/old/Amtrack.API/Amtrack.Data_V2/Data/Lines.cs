using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Lines
    {
        public Lines()
        {
            BrandingInfoLine = new HashSet<BrandingInfoLine>();
            BrandingLineInfo = new HashSet<BrandingLineInfo>();
            LineLinks = new HashSet<LineLinks>();
        }

        public Guid LineId { get; set; }
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
        public string Shelf { get; set; }
        public Guid DocumentId { get; set; }
        public long Flags { get; set; }
        public string DiscountProject { get; set; }
        public string ItemCodeOriginal { get; set; }
        public Guid? FkParentLineId { get; set; }

        public Documents Document { get; set; }
        public DocumentBoxDetail DocumentBoxDetail { get; set; }
        public LineDatas LineDatas { get; set; }
        public ICollection<BrandingInfoLine> BrandingInfoLine { get; set; }
        public ICollection<BrandingLineInfo> BrandingLineInfo { get; set; }
        public ICollection<LineLinks> LineLinks { get; set; }
    }
}

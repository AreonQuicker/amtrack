using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AlptempData
    {
        public int Id { get; set; }
        public string AccountManager { get; set; }
        public string Number { get; set; }
        public string BeginStatus { get; set; }
        public string EndStatus { get; set; }
        public string CarryOver { get; set; }
        public string ShortFall { get; set; }
        public string Gifts { get; set; }
        public string GiftsAlp { get; set; }
        public string Cloting { get; set; }
        public string ClotingAlp { get; set; }
        public string Headwear { get; set; }
        public string HeadwearAlp { get; set; }
        public string Branding { get; set; }
        public string BrandingAlp { get; set; }
        public string PromotionAlp { get; set; }
        public string Total { get; set; }
        public string TotalAlp { get; set; }
        public string CarryOverInto { get; set; }
    }
}

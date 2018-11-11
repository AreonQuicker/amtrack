using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Alpdatas
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string CreditNoteNumber { get; set; }
        public string DocumentNumber { get; set; }
        public short DocumentVersion { get; set; }
        public string ItemCode { get; set; }
        public string AccountManagerCode { get; set; }
        public string CustomerCode { get; set; }
        public double? GiftsTotal { get; set; }
        public double? ClothingTotal { get; set; }
        public double? ClothingHeadgearTotal { get; set; }
        public double? BrandingTotal { get; set; }
        public double? GiftsAlp { get; set; }
        public double? ClothingAlp { get; set; }
        public double? ClothingHeadgearAlp { get; set; }
        public double? BrandingAlp { get; set; }
        public double? PromotionAlp { get; set; }
        public double? OverrideAlp { get; set; }
        public double? OtherAlp { get; set; }
        public double? GlAlp { get; set; }
        public double? TransferAlp { get; set; }
        public double? AdditionalAlp { get; set; }
        public double? StaticTotalAlp { get; set; }
        public double? StaticTotal { get; set; }
        public long Flags { get; set; }
        public long Type { get; set; }
        public int? SubType { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CustomerTeirs
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Customercode { get; set; }
        public double Currentamount { get; set; }
        public double Previousamount { get; set; }
        public int Teir { get; set; }
        public long Flags { get; set; }
        public double? GiftAmount { get; set; }
        public double? ClothingAmount { get; set; }
        public double? BrandingAmount { get; set; }
        public double? PrevGiftAmount { get; set; }
        public double? PrevClothingAmount { get; set; }
        public double? PrevBrandingAmount { get; set; }
        public double? PreTurnoverValue { get; set; }
    }
}

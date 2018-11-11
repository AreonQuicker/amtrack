using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BrandingLineInfo
    {
        public BrandingLineInfo()
        {
            BrandingLineInfoAttachments = new HashSet<BrandingLineInfoAttachments>();
            BrandingLineInfoContacts = new HashSet<BrandingLineInfoContacts>();
        }

        public int Id { get; set; }
        public Guid FkLineId { get; set; }
        public string BrandingPosition { get; set; }
        public int ReapeatInfo { get; set; }
        public string Repeatreference { get; set; }
        public string LogoName { get; set; }
        public string LogoPosition { get; set; }
        public double? PrintSizeWidth { get; set; }
        public double? PrintSizeHeight { get; set; }
        public string PrintColours { get; set; }
        public int? VinylColour { get; set; }
        public int? FoilColour { get; set; }
        public string SpecialInstructions { get; set; }
        public int Flags { get; set; }

        public Lines FkLine { get; set; }
        public ICollection<BrandingLineInfoAttachments> BrandingLineInfoAttachments { get; set; }
        public ICollection<BrandingLineInfoContacts> BrandingLineInfoContacts { get; set; }
    }
}

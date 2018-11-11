using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BrandingInfoLine
    {
        public long Id { get; set; }
        public Guid FkLineId { get; set; }
        public DateTime Created { get; set; }
        public string Size { get; set; }
        public string Position { get; set; }
        public string PantoneColour { get; set; }
        public string VinylColour { get; set; }
        public string FoilColour { get; set; }
        public string SpecialInstructions { get; set; }
        public string ContactIds { get; set; }
        public long? LogoId { get; set; }
        public DateTime? LogoCreated { get; set; }
        public Guid? DownloadLogoGuid { get; set; }
        public string DownloadLogoPath { get; set; }
        public string LogoName { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
        public string ExactRepeatJobCardNumber { get; set; }
        public string LogoRepeatJobCardNumber { get; set; }
        public string LayoutNumber { get; set; }
        public long? AccountContactId { get; set; }

        public Lines FkLine { get; set; }
    }
}

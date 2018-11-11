using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobcardBrandingInstructionVersions
    {
        public JobcardBrandingInstructionVersions()
        {
            BrandingInstructions = new HashSet<BrandingInstructions>();
            PackingInstructions = new HashSet<PackingInstructions>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long? JobCardId { get; set; }
        public int Version { get; set; }
        public string LogoName { get; set; }
        public string ContactPerson { get; set; }
        public string LogoSize { get; set; }
        public string LogoPos { get; set; }
        public bool? RepeatJob { get; set; }
        public string Colours { get; set; }
        public string Instruction { get; set; }
        public long? UserId { get; set; }
        public long? ContactId { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
        public double? PrintSizeWidth { get; set; }
        public double? PrintSizeHeight { get; set; }
        public string PrintColour { get; set; }
        public int? VinylColour { get; set; }
        public int? FoilColour { get; set; }
        public string BrandingPosition { get; set; }

        public ICollection<BrandingInstructions> BrandingInstructions { get; set; }
        public ICollection<PackingInstructions> PackingInstructions { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BrandingLineInfoAttachments
    {
        public int Id { get; set; }
        public int FkBrandingInfoLineId { get; set; }
        public Guid Identifier { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }

        public BrandingLineInfo FkBrandingInfoLine { get; set; }
    }
}

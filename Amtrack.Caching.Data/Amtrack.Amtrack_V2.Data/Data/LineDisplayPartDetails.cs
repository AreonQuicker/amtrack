using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class LineDisplayPartDetails
    {
        public int FkDisplayLineId { get; set; }
        public string PartCode { get; set; }
        public string PartColour { get; set; }
        public string PartDescription { get; set; }
        public int Flags { get; set; }

        public LineDisplay FkDisplayLine { get; set; }
    }
}

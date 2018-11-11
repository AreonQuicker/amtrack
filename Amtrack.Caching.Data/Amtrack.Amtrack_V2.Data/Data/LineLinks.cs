using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class LineLinks
    {
        public Guid FkLineId { get; set; }
        public int FkDisplayLineId { get; set; }

        public LineDisplay FkDisplayLine { get; set; }
        public Lines FkLine { get; set; }
    }
}

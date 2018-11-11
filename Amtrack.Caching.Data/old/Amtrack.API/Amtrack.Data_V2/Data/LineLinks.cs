using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class LineLinks
    {
        public Guid FkLineId { get; set; }
        public int FkDisplayLineId { get; set; }

        public LineDisplay FkDisplayLine { get; set; }
        public Lines FkLine { get; set; }
    }
}

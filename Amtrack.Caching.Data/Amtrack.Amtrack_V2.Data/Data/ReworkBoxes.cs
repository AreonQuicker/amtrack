using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ReworkBoxes
    {
        public long FkWmsDocucmentBoxId { get; set; }
        public long FkReworkId { get; set; }

        public Rework FkRework { get; set; }
        public WmsDocumentBoxes FkWmsDocucmentBox { get; set; }
    }
}

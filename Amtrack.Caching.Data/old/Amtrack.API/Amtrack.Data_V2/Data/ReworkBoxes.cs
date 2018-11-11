using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ReworkBoxes
    {
        public long FkWmsDocucmentBoxId { get; set; }
        public long FkReworkId { get; set; }

        public Rework FkRework { get; set; }
        public WmsDocumentBoxes FkWmsDocucmentBox { get; set; }
    }
}

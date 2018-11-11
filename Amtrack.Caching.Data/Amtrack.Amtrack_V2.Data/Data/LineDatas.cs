﻿using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class LineDatas
    {
        public string Notes { get; set; }
        public long LineDataId { get; set; }
        public Guid FkLineId { get; set; }
        public int? AdditionalStockToPull { get; set; }
        public long Flags { get; set; }

        public Lines FkLine { get; set; }
    }
}

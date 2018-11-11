﻿using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class TurnoverTransfers
    {
        public long TransferId { get; set; }
        public string DocumentNumber { get; set; }
        public short DocumentVersion { get; set; }
        public DateTime DateTransferFrom { get; set; }
        public DateTime DateTransferTo { get; set; }
        public long Flags { get; set; }
    }
}
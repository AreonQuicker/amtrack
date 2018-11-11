﻿using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class InventoryPart
    {
        public int Id { get; set; }
        public int? FkMasterId { get; set; }
        public int? FkSetId { get; set; }
        public string Part { get; set; }
        public long Flags { get; set; }

        public InventoryPartsMaster FkMaster { get; set; }
        public InventorySet FkSet { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ShipmentNumber
    {
        public int Id { get; set; }
        public int LastNumberUsed { get; set; }
        public string BranchCode { get; set; }
    }
}

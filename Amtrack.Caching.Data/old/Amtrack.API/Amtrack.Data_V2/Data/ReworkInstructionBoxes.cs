using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ReworkInstructionBoxes
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkReworkInstructionMasterBoxId { get; set; }
        public string BoxBarcode { get; set; }
        public string BoxName { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ReworkInstructionMasterBoxes FkReworkInstructionMasterBox { get; set; }
    }
}

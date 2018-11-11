using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class PickingInstructions
    {
        public Guid InstructionId { get; set; }
        public string Code { get; set; }
        public string Entity { get; set; }
        public int? Quantity { get; set; }
        public string Location { get; set; }
        public Guid FkPickingSlipId { get; set; }
        public string Text { get; set; }
        public int Sequence { get; set; }

        public PickingSlips FkPickingSlip { get; set; }
    }
}

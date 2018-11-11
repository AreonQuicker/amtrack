using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ReworkInstructionMasterLines
    {
        public ReworkInstructionMasterLines()
        {
            ReworkInstructionLines = new HashSet<ReworkInstructionLines>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long? FkReworkInstructionMasterBoxId { get; set; }
        public long? FkReworkInstructionId { get; set; }
        public string ItemCode { get; set; }
        public int? Quantity { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
        public string Reference { get; set; }
        public int? ReferenceType { get; set; }
        public int? OriginalQuantity { get; set; }

        public ReworkInstructions FkReworkInstruction { get; set; }
        public ReworkInstructionMasterBoxes FkReworkInstructionMasterBox { get; set; }
        public ICollection<ReworkInstructionLines> ReworkInstructionLines { get; set; }
    }
}

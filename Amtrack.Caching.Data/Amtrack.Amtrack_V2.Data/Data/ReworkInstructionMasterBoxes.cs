using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ReworkInstructionMasterBoxes
    {
        public ReworkInstructionMasterBoxes()
        {
            ReworkInstructionBoxes = new HashSet<ReworkInstructionBoxes>();
            ReworkInstructionMasterLines = new HashSet<ReworkInstructionMasterLines>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long? FkReworkInstructionId { get; set; }
        public string BoxBarcode { get; set; }
        public string BoxName { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ReworkInstructions FkReworkInstruction { get; set; }
        public ICollection<ReworkInstructionBoxes> ReworkInstructionBoxes { get; set; }
        public ICollection<ReworkInstructionMasterLines> ReworkInstructionMasterLines { get; set; }
    }
}

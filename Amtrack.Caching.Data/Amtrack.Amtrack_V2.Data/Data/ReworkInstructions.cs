using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ReworkInstructions
    {
        public ReworkInstructions()
        {
            ReworkInstructionData = new HashSet<ReworkInstructionData>();
            ReworkInstructionMasterBoxes = new HashSet<ReworkInstructionMasterBoxes>();
            ReworkInstructionMasterLines = new HashSet<ReworkInstructionMasterLines>();
        }

        public long Id { get; set; }
        public long FkReworkId { get; set; }
        public int Sequence { get; set; }
        public DateTime Created { get; set; }
        public long? FkOpenByUserId { get; set; }
        public long? FkBusyWithUserId { get; set; }
        public long? FkCompletedByUserId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public Rework FkRework { get; set; }
        public ICollection<ReworkInstructionData> ReworkInstructionData { get; set; }
        public ICollection<ReworkInstructionMasterBoxes> ReworkInstructionMasterBoxes { get; set; }
        public ICollection<ReworkInstructionMasterLines> ReworkInstructionMasterLines { get; set; }
    }
}

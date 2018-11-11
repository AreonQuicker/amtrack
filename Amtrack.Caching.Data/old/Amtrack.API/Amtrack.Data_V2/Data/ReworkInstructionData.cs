using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ReworkInstructionData
    {
        public long Id { get; set; }
        public long FkReworkInstructionId { get; set; }
        public DateTime Created { get; set; }
        public string StringValue { get; set; }
        public string StringValue2 { get; set; }
        public int? IntValue { get; set; }
        public int? IntValue2 { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ReworkInstructions FkReworkInstruction { get; set; }
    }
}

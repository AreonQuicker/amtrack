using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ReworkInstructionLines
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long FkReworkInstructionMasterLineId { get; set; }
        public string ItemCode { get; set; }
        public int? Quantity { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
        public string Reference { get; set; }
        public int? ReferenceType { get; set; }
        public int? OriginalQuantity { get; set; }

        public ReworkInstructionMasterLines FkReworkInstructionMasterLine { get; set; }
    }
}

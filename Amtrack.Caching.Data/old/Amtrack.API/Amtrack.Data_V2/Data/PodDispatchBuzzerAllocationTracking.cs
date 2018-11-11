using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class PodDispatchBuzzerAllocationTracking
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkBuzzerAllocationId { get; set; }
        public Guid? FkUserId { get; set; }
        public int TypeCode { get; set; }
        public int Flags { get; set; }

        public PodDispatchBuzzerAllocation FkBuzzerAllocation { get; set; }
        public Users FkUser { get; set; }
    }
}

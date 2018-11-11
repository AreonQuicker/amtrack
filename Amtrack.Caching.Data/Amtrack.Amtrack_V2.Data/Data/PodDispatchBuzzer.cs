using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PodDispatchBuzzer
    {
        public PodDispatchBuzzer()
        {
            PodDispatchBuzzerAllocation = new HashSet<PodDispatchBuzzerAllocation>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string BuzzerNumber { get; set; }
        public string Warehouse { get; set; }
        public int Flags { get; set; }

        public ICollection<PodDispatchBuzzerAllocation> PodDispatchBuzzerAllocation { get; set; }
    }
}

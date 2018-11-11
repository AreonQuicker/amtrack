using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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

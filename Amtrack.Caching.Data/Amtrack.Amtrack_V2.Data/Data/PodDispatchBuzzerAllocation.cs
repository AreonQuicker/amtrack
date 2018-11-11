using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PodDispatchBuzzerAllocation
    {
        public PodDispatchBuzzerAllocation()
        {
            PodDispatchBuzzerAllocationTracking = new HashSet<PodDispatchBuzzerAllocationTracking>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkBuzzerId { get; set; }
        public int FkPodCollectionNoteId { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public PodDispatchBuzzer FkBuzzer { get; set; }
        public PodCollectionNote FkPodCollectionNote { get; set; }
        public ICollection<PodDispatchBuzzerAllocationTracking> PodDispatchBuzzerAllocationTracking { get; set; }
    }
}

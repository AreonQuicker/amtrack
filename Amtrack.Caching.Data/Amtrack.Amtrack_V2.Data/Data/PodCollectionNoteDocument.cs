using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PodCollectionNoteDocument
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkPodCollectionNoteId { get; set; }
        public string DocumentNumber { get; set; }
        public string Waybill { get; set; }
        public int Flags { get; set; }

        public PodCollectionNote FkPodCollectionNote { get; set; }
    }
}

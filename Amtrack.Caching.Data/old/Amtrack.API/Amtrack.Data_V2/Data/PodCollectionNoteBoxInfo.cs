using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class PodCollectionNoteBoxInfo
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int FkPodCollectionNoteId { get; set; }
        public long FkWmsDocumentBoxId { get; set; }
        public string CollectionShelf { get; set; }
        public int Flags { get; set; }

        public PodCollectionNote FkPodCollectionNote { get; set; }
        public WmsDocumentBoxes FkWmsDocumentBox { get; set; }
    }
}

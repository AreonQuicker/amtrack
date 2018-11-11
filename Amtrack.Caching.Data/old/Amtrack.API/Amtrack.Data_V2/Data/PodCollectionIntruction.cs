using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class PodCollectionIntruction
    {
        public PodCollectionIntruction()
        {
            InverseFkParentIntruction = new HashSet<PodCollectionIntruction>();
            PodCollectionInstructionContainer = new HashSet<PodCollectionInstructionContainer>();
            PodCollectionInstructionLocation = new HashSet<PodCollectionInstructionLocation>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkPodCollectionNoteId { get; set; }
        public int? FkParentIntructionId { get; set; }
        public int Type { get; set; }
        public int Sequence { get; set; }
        public DateTime? OpenTimestamp { get; set; }
        public Guid? FkUserId { get; set; }
        public DateTime? CloseTimestamp { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public PodCollectionIntruction FkParentIntruction { get; set; }
        public PodCollectionNote FkPodCollectionNote { get; set; }
        public ICollection<PodCollectionIntruction> InverseFkParentIntruction { get; set; }
        public ICollection<PodCollectionInstructionContainer> PodCollectionInstructionContainer { get; set; }
        public ICollection<PodCollectionInstructionLocation> PodCollectionInstructionLocation { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PodCollectionNote
    {
        public PodCollectionNote()
        {
            PodCollectionIntruction = new HashSet<PodCollectionIntruction>();
            PodCollectionNoteBoxInfo = new HashSet<PodCollectionNoteBoxInfo>();
            PodCollectionNoteDocument = new HashSet<PodCollectionNoteDocument>();
            PodCollectionNoteWaybill = new HashSet<PodCollectionNoteWaybill>();
            PodDispatchBuzzerAllocation = new HashSet<PodDispatchBuzzerAllocation>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public Guid FkCollectionClerk { get; set; }
        public string Number { get; set; }
        public string ConfirmationSlipNumber { get; set; }
        public string Courier { get; set; }
        public string CustomerCode { get; set; }
        public string CollectionBranchCode { get; set; }
        public int Status { get; set; }
        public DateTime? DispatchStart { get; set; }
        public Guid? FkDispatcher { get; set; }
        public long? FkStagingLocationId { get; set; }
        public int Flags { get; set; }

        public Users FkCollectionClerkNavigation { get; set; }
        public ICollection<PodCollectionIntruction> PodCollectionIntruction { get; set; }
        public ICollection<PodCollectionNoteBoxInfo> PodCollectionNoteBoxInfo { get; set; }
        public ICollection<PodCollectionNoteDocument> PodCollectionNoteDocument { get; set; }
        public ICollection<PodCollectionNoteWaybill> PodCollectionNoteWaybill { get; set; }
        public ICollection<PodDispatchBuzzerAllocation> PodDispatchBuzzerAllocation { get; set; }
    }
}

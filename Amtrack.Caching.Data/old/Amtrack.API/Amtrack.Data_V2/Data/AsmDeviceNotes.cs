using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AsmDeviceNotes
    {
        public Guid NoteId { get; set; }
        public DateTime Created { get; set; }
        public int FkNoteCreator { get; set; }
        public short Type { get; set; }
        public string NoteData { get; set; }
        public Guid FkDeviceId { get; set; }

        public AsmDevice FkDevice { get; set; }
        public HistoryContributor FkNoteCreatorNavigation { get; set; }
    }
}

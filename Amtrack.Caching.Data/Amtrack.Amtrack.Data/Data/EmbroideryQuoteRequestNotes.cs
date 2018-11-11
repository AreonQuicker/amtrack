using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class EmbroideryQuoteRequestNotes
    {
        public long EmbroideryRequestId { get; set; }
        public int PositionNo { get; set; }
        public long NoteId { get; set; }
        public short? Type { get; set; }
    }
}

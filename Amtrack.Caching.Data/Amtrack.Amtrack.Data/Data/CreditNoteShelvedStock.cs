using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CreditNoteShelvedStock
    {
        public long LineId { get; set; }
        public long CreditNoteId { get; set; }
        public string RecomendedShelf { get; set; }
        public string ShelfChosen { get; set; }

        public CreditNote CreditNote { get; set; }
        public Line Line { get; set; }
    }
}

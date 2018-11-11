using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class CreditNoteLogs
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int? CreditNoteId { get; set; }
        public string SalesOrderNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string CreditNoteNumber { get; set; }
        public bool? Success { get; set; }
        public string CreditNoteRequestId { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class CreditNoteProcesses
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int? FkSourcePastelCreditNoteId { get; set; }
        public int? FkDestinationPastelCreditNoteId { get; set; }
        public string SalesOrderNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string CreditNoteNumber { get; set; }
        public long? FkCreditNoteRequestId { get; set; }
        public bool? Success { get; set; }
        public bool? HasPlaceCreditNoteInPastel { get; set; }
        public bool? HasPlaceCreditNoteInAmtrack { get; set; }
        public bool? HasProcessCreditNoteInPastel { get; set; }
        public bool? HasProcessCreditNoteInAmtrack { get; set; }
        public bool? HasProcessDelivery { get; set; }
    }
}

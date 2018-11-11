using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WdbRecentCreditNotes
    {
        public string DocumentNumber { get; set; }
        public string AccountNumber { get; set; }
        public string LinkDocumentNumber { get; set; }
        public string CustomerReference { get; set; }
        public DateTime DocumentDate { get; set; }
        public string FirstLineItem { get; set; }
        public int LineCount { get; set; }
        public double TotalExcl { get; set; }
        public double TotalIncl { get; set; }
    }
}

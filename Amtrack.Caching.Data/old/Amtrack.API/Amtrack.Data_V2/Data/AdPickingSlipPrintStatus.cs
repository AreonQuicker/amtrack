using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AdPickingSlipPrintStatus
    {
        public long Id { get; set; }
        public DateTime? ActionDate { get; set; }
        public string PickingSlipNumber { get; set; }
        public bool Printed { get; set; }
        public DateTime? DatePrinted { get; set; }
        public bool PrintingDelayed { get; set; }
        public DateTime? DatePrintDelayed { get; set; }
        public bool DelayLifted { get; set; }
        public DateTime? DateDelayLifted { get; set; }
        public string PrintDelayReasonCode { get; set; }
        public bool Cancelled { get; set; }
        public DateTime? DateCancelled { get; set; }
        public bool PrintQueued { get; set; }
        public DateTime? DatePrintQueued { get; set; }
        public DateTime? AdminTimeDelay { get; set; }
    }
}

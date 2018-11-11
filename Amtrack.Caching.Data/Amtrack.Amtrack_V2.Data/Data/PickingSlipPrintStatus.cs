using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PickingSlipPrintStatus
    {
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

        public PrintDelayedReasons PrintDelayReasonCodeNavigation { get; set; }
    }
}

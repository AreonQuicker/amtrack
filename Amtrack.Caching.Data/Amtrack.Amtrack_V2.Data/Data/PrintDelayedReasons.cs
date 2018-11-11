using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PrintDelayedReasons
    {
        public PrintDelayedReasons()
        {
            PickingSlipPrintStatus = new HashSet<PickingSlipPrintStatus>();
        }

        public string ReasonCode { get; set; }
        public string Reason { get; set; }

        public ICollection<PickingSlipPrintStatus> PickingSlipPrintStatus { get; set; }
    }
}

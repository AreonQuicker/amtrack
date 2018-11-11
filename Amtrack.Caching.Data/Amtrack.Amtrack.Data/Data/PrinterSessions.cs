using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PrinterSessions
    {
        public long Id { get; set; }
        public int FkPrinterQueueId { get; set; }
        public long FkApisessionId { get; set; }

        public ApiSessions FkApisession { get; set; }
        public PrinterQueues FkPrinterQueue { get; set; }
    }
}

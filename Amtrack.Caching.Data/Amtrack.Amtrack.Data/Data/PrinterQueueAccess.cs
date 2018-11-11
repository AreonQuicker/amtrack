using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PrinterQueueAccess
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string ComputerName { get; set; }
        public int FkPrinterQueueId { get; set; }
        public long Flags { get; set; }

        public PrinterQueues FkPrinterQueue { get; set; }
    }
}

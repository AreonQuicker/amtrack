using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class PrinterQueues
    {
        public PrinterQueues()
        {
            PrinterQueueAccess = new HashSet<PrinterQueueAccess>();
            PrinterSessions = new HashSet<PrinterSessions>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public string Folder { get; set; }
        public int Type { get; set; }
        public long Flags { get; set; }

        public ICollection<PrinterQueueAccess> PrinterQueueAccess { get; set; }
        public ICollection<PrinterSessions> PrinterSessions { get; set; }
    }
}

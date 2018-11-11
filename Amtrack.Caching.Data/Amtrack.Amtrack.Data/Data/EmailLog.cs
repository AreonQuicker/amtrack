using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class EmailLog
    {
        public long LogId { get; set; }
        public string Recipients { get; set; }
        public string Cc { get; set; }
        public string Attachments { get; set; }
        public string Subject { get; set; }
        public DateTime DateSent { get; set; }
        public string Bcc { get; set; }
    }
}

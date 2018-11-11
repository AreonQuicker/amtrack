using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AsmLogBook
    {
        public long LogId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
        public Guid FkDeviceId { get; set; }
        public int FkOutIssuerId { get; set; }
        public int FkOutReceivedId { get; set; }
        public bool? ReceivedIgo { get; set; }
        public bool? ReceivedBigo { get; set; }
        public short Type { get; set; }
        public long Flags { get; set; }
        public int? FkInReceiverId { get; set; }
        public int? FkInReceivedFromId { get; set; }
    }
}

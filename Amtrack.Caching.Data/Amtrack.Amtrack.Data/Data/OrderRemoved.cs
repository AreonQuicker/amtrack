using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class OrderRemoved
    {
        public int Id { get; set; }
        public string ProcessId { get; set; }
        public long OrderId { get; set; }
        public DateTime RemovedFrom { get; set; }
        public DateTime RemovedTo { get; set; }
        public string StringValue { get; set; }
        public string FloatValue { get; set; }
        public long? UserId { get; set; }
    }
}

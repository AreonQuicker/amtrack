using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ReworkReport
    {
        public long Id { get; set; }
        public string OrderNumber { get; set; }
        public string Location { get; set; }
        public int Status { get; set; }
        public DateTime Created { get; set; }
    }
}

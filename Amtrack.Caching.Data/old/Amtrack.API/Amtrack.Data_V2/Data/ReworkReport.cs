using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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

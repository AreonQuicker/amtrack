using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class LineDisplayComponents
    {
        public long Id { get; set; }
        public int FkDisplayLineId { get; set; }
        public DateTime Created { get; set; }
        public string Prefix { get; set; }
        public string BaseCode { get; set; }
        public string ItemCode { get; set; }
        public int Flags { get; set; }
        public int Status { get; set; }

        public LineDisplay FkDisplayLine { get; set; }
    }
}

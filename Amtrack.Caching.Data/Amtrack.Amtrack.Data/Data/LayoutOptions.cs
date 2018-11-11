using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LayoutOptions
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public long FkLayoutId { get; set; }
        public int OptionNumber { get; set; }
        public string PageNumbers { get; set; }
        public string StringValue { get; set; }
        public int Flags { get; set; }
        public int Status { get; set; }
        public string RelativePath { get; set; }

        public Layout FkLayout { get; set; }
    }
}

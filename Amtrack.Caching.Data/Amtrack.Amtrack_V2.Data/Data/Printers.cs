using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Printers
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PrintFolder { get; set; }
        public int FormatType { get; set; }
        public int Status { get; set; }
        public string Barcode { get; set; }
        public long? FkBranchId { get; set; }
        public DateTime Created { get; set; }

        public Branches FkBranch { get; set; }
    }
}

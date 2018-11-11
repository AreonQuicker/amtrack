using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ProductionQctask
    {
        public int Id { get; set; }
        public long FkDepartmentId { get; set; }
        public string Task { get; set; }
        public string Owner { get; set; }
        public byte SortOrder { get; set; }
    }
}

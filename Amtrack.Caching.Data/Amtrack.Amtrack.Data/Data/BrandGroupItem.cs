using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandGroupItem
    {
        public Guid GroupItemId { get; set; }
        public string BaseCode { get; set; }
        public Guid BrandItemGroupGroupId { get; set; }

        public BrandItemGroup BrandItemGroupGroup { get; set; }
    }
}

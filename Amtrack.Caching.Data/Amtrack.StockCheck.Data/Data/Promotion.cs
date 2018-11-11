using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class Promotion
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
    }
}

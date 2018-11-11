using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class AudStAllocateStock
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string ItemCode { get; set; }
        public string SourceCode { get; set; }
        public string Originator { get; set; }
        public string Reference { get; set; }
        public string Reference2 { get; set; }
        public int Quantity { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Alpvalues
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public string CustomerCode { get; set; }
        public string Reference1 { get; set; }
        public string Reference2 { get; set; }
        public string Reference3 { get; set; }
        public double Alp { get; set; }
        public double SalesValue { get; set; }
        public double Units { get; set; }
        public bool IsStatic { get; set; }
        public int? InventoryType { get; set; }
        public int Type { get; set; }
        public int SubType { get; set; }
        public int Flags { get; set; }
    }
}

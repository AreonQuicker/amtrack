using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class SwadSummary
    {
        public long Id { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public int Minutes { get; set; }
        public int WeightError { get; set; }
        public int DimError { get; set; }
        public int ReadError { get; set; }
        public int Total { get; set; }
        public bool Finalised { get; set; }
    }
}

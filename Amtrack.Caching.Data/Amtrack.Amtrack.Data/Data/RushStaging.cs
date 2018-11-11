using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class RushStaging
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string DocumentNumber { get; set; }
        public long UserId { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public DateTime Date { get; set; }
    }
}

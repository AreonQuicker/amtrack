using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class SpecialInstuctions
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public string StringValue { get; set; }
        public int? Flag { get; set; }
        public int? Status { get; set; }

        public JobCardSpecialInstructions JobCardSpecialInstructions { get; set; }
    }
}

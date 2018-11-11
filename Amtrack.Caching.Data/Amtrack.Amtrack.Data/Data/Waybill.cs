using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Waybill
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string Number { get; set; }
        public string Courier { get; set; }
        public string Notes { get; set; }
    }
}

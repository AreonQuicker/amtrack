using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class SpecialDates
    {
        public Guid SpecialDateId { get; set; }
        public long Year { get; set; }
        public DateTime SpecialDateValue { get; set; }
        public string Name { get; set; }
        public long SpecialDatesFlag { get; set; }
    }
}

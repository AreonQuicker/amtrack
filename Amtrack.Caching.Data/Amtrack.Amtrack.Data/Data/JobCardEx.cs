using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class JobCardEx
    {
        public long JobCardId { get; set; }
        public int? Sides { get; set; }
        public int? VinylColour { get; set; }
        public int? LayoutOptions { get; set; }
        public string SalesRep { get; set; }
        public long? ContactPersonId { get; set; }
        public int? AdditionalStatus { get; set; }
        public int? StitchesDigitized { get; set; }

        public JobCard JobCard { get; set; }
    }
}

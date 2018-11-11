using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class AlpmidYearDatas
    {
        public string CustomerCode { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public double SpendGifts { get; set; }
        public double SpendClothing { get; set; }
        public double SpendBranding { get; set; }
        public double AlpGifts { get; set; }
        public double AlpClothing { get; set; }
        public double AlpBranding { get; set; }
        public double SpendTotal { get; set; }
        public double AlpTotal { get; set; }
        public int Year { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class TempNotCreatable
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public int Cartons { get; set; }
        public int Upc { get; set; }
        public int Total { get; set; }
    }
}

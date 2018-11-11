using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
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

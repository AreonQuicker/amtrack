using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class Currency
    {
        public Currency()
        {
            Branches = new HashSet<Branches>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public short DecimalDisplayLimit { get; set; }
        public string DisplayFormat { get; set; }
        public int Flags { get; set; }

        public ICollection<Branches> Branches { get; set; }
    }
}

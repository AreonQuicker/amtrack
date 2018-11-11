using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class SpecialsTypes
    {
        public SpecialsTypes()
        {
            Specials = new HashSet<Specials>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Flags { get; set; }

        public ICollection<Specials> Specials { get; set; }
    }
}

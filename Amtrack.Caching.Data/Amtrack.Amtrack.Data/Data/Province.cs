using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Province
    {
        public Province()
        {
            SuburbCity = new HashSet<SuburbCity>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public ICollection<SuburbCity> SuburbCity { get; set; }
    }
}

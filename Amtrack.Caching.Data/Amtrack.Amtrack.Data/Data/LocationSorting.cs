using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LocationSorting
    {
        public int Id { get; set; }
        public long FkLocationId { get; set; }
        public int SortingType { get; set; }
        public int SortIndex { get; set; }

        public Location FkLocation { get; set; }
    }
}

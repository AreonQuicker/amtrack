using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Location
    {
        public Location()
        {
            LocationHierarchyPkNavigation = new HashSet<LocationHierarchy>();
            LocationItems = new HashSet<LocationItems>();
            LocationJobCards = new HashSet<LocationJobCards>();
            LocationSorting = new HashSet<LocationSorting>();
            LocationTracking = new HashSet<LocationTracking>();
            ParcelLocations = new HashSet<ParcelLocations>();
            TerminalLocations = new HashSet<TerminalLocations>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public long NestedLevel { get; set; }
        public string Branch { get; set; }

        public LocationHierarchy LocationHierarchyFkNavigation { get; set; }
        public ICollection<LocationHierarchy> LocationHierarchyPkNavigation { get; set; }
        public ICollection<LocationItems> LocationItems { get; set; }
        public ICollection<LocationJobCards> LocationJobCards { get; set; }
        public ICollection<LocationSorting> LocationSorting { get; set; }
        public ICollection<LocationTracking> LocationTracking { get; set; }
        public ICollection<ParcelLocations> ParcelLocations { get; set; }
        public ICollection<TerminalLocations> TerminalLocations { get; set; }
    }
}

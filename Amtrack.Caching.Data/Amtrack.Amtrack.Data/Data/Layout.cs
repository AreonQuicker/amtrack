using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Layout
    {
        public Layout()
        {
            LayoutOptions = new HashSet<LayoutOptions>();
            LayoutTracking = new HashSet<LayoutTracking>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Number { get; set; }
        public int Revision { get; set; }
        public string RelativePath { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }
        public byte? Options { get; set; }

        public JobCardLayouts JobCardLayouts { get; set; }
        public LayoutArtists LayoutArtists { get; set; }
        public ICollection<LayoutOptions> LayoutOptions { get; set; }
        public ICollection<LayoutTracking> LayoutTracking { get; set; }
    }
}

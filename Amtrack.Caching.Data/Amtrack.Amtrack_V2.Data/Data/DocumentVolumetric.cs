using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DocumentVolumetric
    {
        public long Id { get; set; }
        public string DocumentNumber { get; set; }
        public short DocumentVersion { get; set; }
        public string ItemCode { get; set; }
        public double Volumetric { get; set; }
        public int Flags { get; set; }
        public double Weight { get; set; }
    }
}

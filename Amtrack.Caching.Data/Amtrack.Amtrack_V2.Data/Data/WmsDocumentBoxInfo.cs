using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class WmsDocumentBoxInfo
    {
        public long Id { get; set; }
        public long FkWmsDocumentBoxId { get; set; }
        public double? Length { get; set; }
        public string LengthUnit { get; set; }
        public double? Width { get; set; }
        public string WidthUnit { get; set; }
        public double? Height { get; set; }
        public string HeightUnit { get; set; }
        public double? Weight { get; set; }
        public string WeightUnit { get; set; }
        public long? UserId { get; set; }
        public int Type { get; set; }
        public int Source { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public WmsDocumentBoxes FkWmsDocumentBox { get; set; }
    }
}

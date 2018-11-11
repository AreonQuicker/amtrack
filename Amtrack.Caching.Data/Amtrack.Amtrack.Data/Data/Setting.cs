using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Setting
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public int Protection { get; set; }
        public string StringValue { get; set; }
        public long? IntegralValue { get; set; }
        public double? FloatValue { get; set; }
        public DateTime? DateValue { get; set; }
        public bool? BoolValue { get; set; }
    }
}

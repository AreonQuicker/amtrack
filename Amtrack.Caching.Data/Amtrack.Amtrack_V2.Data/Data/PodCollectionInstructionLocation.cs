using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class PodCollectionInstructionLocation
    {
        public int Id { get; set; }
        public int FkInstructionId { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }

        public PodCollectionIntruction FkInstruction { get; set; }
    }
}

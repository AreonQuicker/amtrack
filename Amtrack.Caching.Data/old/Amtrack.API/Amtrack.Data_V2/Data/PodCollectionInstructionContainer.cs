using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class PodCollectionInstructionContainer
    {
        public int Id { get; set; }
        public int FkInstructionId { get; set; }
        public string DocumentNumber { get; set; }
        public string Barcode { get; set; }
        public string Number { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }

        public PodCollectionIntruction FkInstruction { get; set; }
    }
}

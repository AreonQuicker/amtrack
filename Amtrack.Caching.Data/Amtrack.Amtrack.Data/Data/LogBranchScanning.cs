using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LogBranchScanning
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Barcode { get; set; }
        public string Response { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class AudWmsDocumentFlags
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string WmsDocumentNumber { get; set; }
        public int Flags { get; set; }
    }
}

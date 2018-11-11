using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class CmtProcess
    {
        public long JobcardId { get; set; }
        public bool Jcp { get; set; }
        public bool Graphics { get; set; }
        public bool Sublimation { get; set; }
        public bool Cmt { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class DestroyedPalletInfo
    {
        public long Id { get; set; }
        public Guid FkPalletId { get; set; }
        public string ReasonCode { get; set; }
        public DateTime? Created { get; set; }
        public string ActionarCode { get; set; }
        public long? Flags { get; set; }
    }
}

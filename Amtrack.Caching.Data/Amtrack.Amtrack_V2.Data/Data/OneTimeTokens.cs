using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class OneTimeTokens
    {
        public Guid TokenId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime? DateConsumed { get; set; }
        public Guid FkUserId { get; set; }

        public Users FkUser { get; set; }
    }
}

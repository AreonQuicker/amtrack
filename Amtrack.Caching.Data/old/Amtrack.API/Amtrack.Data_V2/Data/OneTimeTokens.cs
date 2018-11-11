using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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

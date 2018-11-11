using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BrandingConversionMembers
    {
        public int MemberId { get; set; }
        public int FkGroupId { get; set; }
        public Guid FkUserId { get; set; }
        public long Flags { get; set; }

        public BrandingConversionGroups FkGroup { get; set; }
        public Users FkUser { get; set; }
    }
}

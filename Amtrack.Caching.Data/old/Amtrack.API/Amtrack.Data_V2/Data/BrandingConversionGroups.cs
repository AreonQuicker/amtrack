using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BrandingConversionGroups
    {
        public BrandingConversionGroups()
        {
            BrandingConversionMembers = new HashSet<BrandingConversionMembers>();
        }

        public int GroupId { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public Guid FkOwnerId { get; set; }
        public long Flags { get; set; }

        public Users FkOwner { get; set; }
        public ICollection<BrandingConversionMembers> BrandingConversionMembers { get; set; }
    }
}

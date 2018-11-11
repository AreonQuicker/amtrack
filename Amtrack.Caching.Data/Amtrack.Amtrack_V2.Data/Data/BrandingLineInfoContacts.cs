using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BrandingLineInfoContacts
    {
        public int Id { get; set; }
        public int FkBrandingInfoLineId { get; set; }
        public int FkAccountContactId { get; set; }

        public AccountContacts FkAccountContact { get; set; }
        public BrandingLineInfo FkBrandingInfoLine { get; set; }
    }
}

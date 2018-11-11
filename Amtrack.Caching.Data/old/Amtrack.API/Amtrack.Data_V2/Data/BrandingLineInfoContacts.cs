using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
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

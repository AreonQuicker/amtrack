using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class Specials
    {
        public Specials()
        {
            SpecialApplicableProducts = new HashSet<SpecialApplicableProducts>();
            SpecialsBrandingDetails = new HashSet<SpecialsBrandingDetails>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int Flags { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }

        public SpecialsTypes TypeNavigation { get; set; }
        public ICollection<SpecialApplicableProducts> SpecialApplicableProducts { get; set; }
        public ICollection<SpecialsBrandingDetails> SpecialsBrandingDetails { get; set; }
    }
}

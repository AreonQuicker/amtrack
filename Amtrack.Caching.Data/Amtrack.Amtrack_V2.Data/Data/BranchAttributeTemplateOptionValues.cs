using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BranchAttributeTemplateOptionValues
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int FkTemplateId { get; set; }
        public int Sequence { get; set; }
        public string Display { get; set; }
        public string Value { get; set; }

        public BranchAttributeTemplates FkTemplate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class BranchAttributeTemplates
    {
        public BranchAttributeTemplates()
        {
            BranchAttributeTemplateOptionValues = new HashSet<BranchAttributeTemplateOptionValues>();
            BranchAttributes = new HashSet<BranchAttributes>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Section { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public int Flags { get; set; }

        public ICollection<BranchAttributeTemplateOptionValues> BranchAttributeTemplateOptionValues { get; set; }
        public ICollection<BranchAttributes> BranchAttributes { get; set; }
    }
}

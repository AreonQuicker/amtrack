using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class BranchAttributes
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public long FkBranchId { get; set; }
        public int FkAttributeTemplateId { get; set; }
        public long? NumericValue { get; set; }
        public string StringValue { get; set; }
        public double? FloatValue { get; set; }
        public bool? BoolValue { get; set; }
        public string TextValue { get; set; }
        public int Flags { get; set; }

        public BranchAttributeTemplates FkAttributeTemplate { get; set; }
        public Branches FkBranch { get; set; }
    }
}

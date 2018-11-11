using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Alps
    {
        public Alps()
        {
            AlppointRules = new HashSet<AlppointRules>();
            AlppointsTypes = new HashSet<AlppointsTypes>();
            Alptargets = new HashSet<Alptargets>();
            BranchAlps = new HashSet<BranchAlps>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public int Year { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
        public DateTime? CutOffDate { get; set; }

        public ICollection<AlppointRules> AlppointRules { get; set; }
        public ICollection<AlppointsTypes> AlppointsTypes { get; set; }
        public ICollection<Alptargets> Alptargets { get; set; }
        public ICollection<BranchAlps> BranchAlps { get; set; }
    }
}

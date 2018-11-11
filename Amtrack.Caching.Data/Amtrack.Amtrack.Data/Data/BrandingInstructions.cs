using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class BrandingInstructions
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public long? UserCreateId { get; set; }
        public long? UserEditId { get; set; }
        public long? UserDeleteId { get; set; }
        public long? FkBrandingVersion { get; set; }
        public string Instruction { get; set; }
        public int Flags { get; set; }
        public int Status { get; set; }
        public long? FkInstructionId { get; set; }

        public JobcardBrandingInstructionVersions FkBrandingVersionNavigation { get; set; }
    }
}

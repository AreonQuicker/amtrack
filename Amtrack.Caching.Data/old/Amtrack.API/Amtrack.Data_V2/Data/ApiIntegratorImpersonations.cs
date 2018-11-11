using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ApiIntegratorImpersonations
    {
        public int Id { get; set; }
        public int FkIntegratorId { get; set; }
        public string CustomerCode { get; set; }
        public int Flags { get; set; }

        public ApiIntegrator FkIntegrator { get; set; }
    }
}

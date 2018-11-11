using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ApiIntegratorRoles
    {
        public int FkIntegratorId { get; set; }
        public int FkRoleId { get; set; }

        public ApiIntegrator FkIntegrator { get; set; }
        public ApiRoles FkRole { get; set; }
    }
}

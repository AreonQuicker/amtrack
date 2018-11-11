using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ApiIntegratorRoles
    {
        public int FkIntegratorId { get; set; }
        public int FkRoleId { get; set; }

        public ApiIntegrator FkIntegrator { get; set; }
        public ApiRoles FkRole { get; set; }
    }
}

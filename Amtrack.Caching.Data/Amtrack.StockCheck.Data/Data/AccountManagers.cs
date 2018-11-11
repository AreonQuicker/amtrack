using System;
using System.Collections.Generic;

namespace Amtrack.StockCheck.Data.Data
{
    public partial class AccountManagers
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string DirectLine { get; set; }
        public string Cell { get; set; }
        public string AccountManagerCode { get; set; }
    }
}

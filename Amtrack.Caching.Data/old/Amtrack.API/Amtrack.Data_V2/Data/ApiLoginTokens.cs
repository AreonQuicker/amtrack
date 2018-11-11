using System;
using System.Collections.Generic;

namespace Amtrack.Data_V2.Data
{
    public partial class ApiLoginTokens
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Token { get; set; }
        public long AccountId { get; set; }
        public long CustomerId { get; set; }
        public string ClientId { get; set; }
        public int Flags { get; set; }
    }
}

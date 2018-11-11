using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class ClientContact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }

        public ClientDelivery ClientDelivery { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ContactWebInfo
    {
        public string AccountNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public DateTime? Bday { get; set; }
        public string Position { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ApprovedJobCardUsers
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public long? ContactId { get; set; }
        public string BirthDay { get; set; }
        public string ReferenceNumber { get; set; }
        public long JobCardId { get; set; }
        public long LayoutId { get; set; }
        public int? LayoutOption { get; set; }
        public Guid? ContactGuid { get; set; }
        public Guid AccountGuid { get; set; }
        public long? UserId { get; set; }
        public int Status { get; set; }
        public int Flags { get; set; }
    }
}

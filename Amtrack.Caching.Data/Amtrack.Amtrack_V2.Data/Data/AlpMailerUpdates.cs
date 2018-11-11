using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class AlpMailerUpdates
    {
        public AlpMailerUpdates()
        {
            AlpMailerRecipients = new HashSet<AlpMailerRecipients>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public Guid FkAuthor { get; set; }
        public DateTime? Date { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public string Bcc { get; set; }
        public DateTime? ScheduledDate { get; set; }

        public ICollection<AlpMailerRecipients> AlpMailerRecipients { get; set; }
    }
}

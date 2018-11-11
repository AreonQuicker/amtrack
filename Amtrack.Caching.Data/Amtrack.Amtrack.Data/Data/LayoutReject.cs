using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class LayoutReject
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public long FkLayoutId { get; set; }
        public long JobcardManagerId { get; set; }
        public long RejectedById { get; set; }
        public long LayoutArtistId { get; set; }
        public string Reason { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class StockTakeEntries
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public byte Type { get; set; }
        public long FkLocationId { get; set; }
        public long FkAuthorId { get; set; }
        public string DataIn { get; set; }
        public string DataExp { get; set; }
        public long? FkUserResolverId { get; set; }
        public DateTime? DateResolved { get; set; }
        public byte? ActionType { get; set; }
        public string ActionComments { get; set; }
        public int Flags { get; set; }
    }
}

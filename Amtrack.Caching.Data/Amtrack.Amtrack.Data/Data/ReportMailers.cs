using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class ReportMailers
    {
        public ReportMailers()
        {
            ReportMailerSchedule = new HashSet<ReportMailerSchedule>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public string Name { get; set; }
        public string Heading { get; set; }
        public string Recipients { get; set; }
        public string Sql { get; set; }
        public string Exportheadingoverwrite { get; set; }
        public string Exportcolumnsoverwrite { get; set; }

        public ICollection<ReportMailerSchedule> ReportMailerSchedule { get; set; }
    }
}

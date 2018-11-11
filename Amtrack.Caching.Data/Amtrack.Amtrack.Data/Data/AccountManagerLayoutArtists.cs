using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class AccountManagerLayoutArtists
    {
        public long AccountManagerId { get; set; }
        public long PrintDepartmentId { get; set; }
        public long? LayoutArtistId { get; set; }

        public User AccountManager { get; set; }
        public User LayoutArtist { get; set; }
        public PrintDepartment PrintDepartment { get; set; }
    }
}

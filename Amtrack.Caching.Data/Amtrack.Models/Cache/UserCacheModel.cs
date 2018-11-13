using System;
using System.Collections.Generic;
using System.Text;
using Amtrack.ValueObjects.Security;
using Amtrack.ValueObjects.Users;

namespace Amtrack.Models.Cache
{
    public class UserCacheModel : ICacheModel
    {
        public List<SecurityLevelVO> SecurityLevels { get; set; }
        public List<UserVO> Users { get; set; }
    }
}

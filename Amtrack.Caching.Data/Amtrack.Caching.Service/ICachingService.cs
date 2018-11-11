using System.Collections.Generic;
using Amtrack.Models;
using Amtrack.ValueObjects.Inventory;
using Amtrack.ValueObjects.OrderEntry;
using Amtrack.ValueObjects.Security;
using Amtrack.ValueObjects.Users;

namespace Amtrack.Caching.Service
{
    public interface ICachingService
    {
        UserCacheModel GetUserCacheModel();
        InventoryCacheModel GetInventoryCacheModel();     
    }
}

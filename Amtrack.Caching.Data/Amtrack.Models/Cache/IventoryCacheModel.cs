using System.Collections.Generic;
using Amtrack.ValueObjects.Branding;
using Amtrack.ValueObjects.Inventory;
using Amtrack.ValueObjects.OrderEntry;

namespace Amtrack.Models.Cache
{
	public class InventoryCacheModel : ICacheModel
	{
		public List<PriceListVO> PriceLists { get; set; }
		public List<GroupVO> Groups { get; set; }
		public List<InventoryItemVO> InventoryItems { get; set; }
		public List<InventoryPricingVO> InventoryPricing { get; set; }
		public List<InventorySetVO> InventorySets { get; set; }
		public List<EmbroideryPricingVO> EmbroideryPricing { get; set; }
	}
}

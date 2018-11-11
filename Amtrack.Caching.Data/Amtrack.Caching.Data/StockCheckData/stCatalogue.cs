using System;

namespace Amtrack.Caching.Data.StockCheckData
{
	public class stCatalogue
	{
		public stCatalogue()
		{

		}
		public int InventoryId { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
		public string BaseItemCode { get; set; }
		public string ItemCode { get; set; }
		public string Description { get; set; }
		public string Colour { get; set; }
		public string Size { get; set; }
		public int InventoryType { get; set; }
		public int InventoryFlags { get; set; }
		public int InventoryGroupId { get; set; }
		public string InventoryGroupCode { get; set; }
		public string InventoryGroupName { get; set; }
		public int InventoryGroupFlags { get; set; }
		public bool WarehouseItem { get; set; }
		public bool HighValue { get; set; }
		public bool DangerouGoods { get; set; }
		public bool InvoiceItem { get; set; }
		public bool QuoteItem { get; set; }
		public bool OnPromotion { get; set; }
		public bool SampleShopQuantityExeption { get; set; }
		public string ALPCategory { get; set; }
		public string ColourSortIndex { get; set; }
		public string Brands { get; set; }
	}
}

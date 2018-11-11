using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Line
    {
        public Line()
        {
            CreditNoteRequestDetail = new HashSet<CreditNoteRequestDetail>();
            CreditNoteShelvedStock = new HashSet<CreditNoteShelvedStock>();
            FaultyGoodsRequests = new HashSet<FaultyGoodsRequests>();
            LineJobCards = new HashSet<LineJobCards>();
            LinkLineJobCards = new HashSet<LinkLineJobCards>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public int Type { get; set; }
        public string Barcode { get; set; }
        public string StockCode { get; set; }
        public string Description { get; set; }
        public double Quantity { get; set; }
        public double UnitPriceExcl { get; set; }
        public double UnitPriceIncl { get; set; }
        public double UnitVatAmount { get; set; }
        public double LineAmountExcl { get; set; }
        public double LineAmountIncl { get; set; }
        public double LineVatAmount { get; set; }
        public int RowNumber { get; set; }
        public int Status { get; set; }
        public string ShelfNumber { get; set; }

        public CreditNoteDetail CreditNoteDetail { get; set; }
        public JobCardsForPrintLines JobCardsForPrintLines { get; set; }
        public OrderDetail OrderDetail { get; set; }
        public ICollection<CreditNoteRequestDetail> CreditNoteRequestDetail { get; set; }
        public ICollection<CreditNoteShelvedStock> CreditNoteShelvedStock { get; set; }
        public ICollection<FaultyGoodsRequests> FaultyGoodsRequests { get; set; }
        public ICollection<LineJobCards> LineJobCards { get; set; }
        public ICollection<LinkLineJobCards> LinkLineJobCards { get; set; }
    }
}

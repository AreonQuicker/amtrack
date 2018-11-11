using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class Order
    {
        public Order()
        {
            BatchedOrders = new HashSet<BatchedOrders>();
            ClBatchContents = new HashSet<ClBatchContents>();
            CreditNoteOrder = new HashSet<CreditNoteOrder>();
            CreditNoteRequestOrder = new HashSet<CreditNoteRequestOrder>();
            DeliveryRequestContents = new HashSet<DeliveryRequestContents>();
            InvoiceAttachments = new HashSet<InvoiceAttachments>();
            LinkedReturnStock = new HashSet<LinkedReturnStock>();
            LqAllocation = new HashSet<LqAllocation>();
            OrderCustomerNotes = new HashSet<OrderCustomerNotes>();
            OrderDetail = new HashSet<OrderDetail>();
            OrderNotes = new HashSet<OrderNotes>();
            OrderQuery = new HashSet<OrderQuery>();
            OrderTracking = new HashSet<OrderTracking>();
            Packaging = new HashSet<Packaging>();
            PaymentInformation = new HashSet<PaymentInformation>();
            PrintJobs = new HashSet<PrintJobs>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Barcode { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalExcl { get; set; }
        public double TotalIncl { get; set; }
        public double VatAmount { get; set; }
        public int Status { get; set; }
        public int? Flags { get; set; }
        public string WarehouseNumber { get; set; }
        public string CustomerReference { get; set; }

        public AccountOrders AccountOrders { get; set; }
        public LocationItems LocationItems { get; set; }
        public SalesRepresentatives SalesRepresentatives { get; set; }
        public ICollection<BatchedOrders> BatchedOrders { get; set; }
        public ICollection<ClBatchContents> ClBatchContents { get; set; }
        public ICollection<CreditNoteOrder> CreditNoteOrder { get; set; }
        public ICollection<CreditNoteRequestOrder> CreditNoteRequestOrder { get; set; }
        public ICollection<DeliveryRequestContents> DeliveryRequestContents { get; set; }
        public ICollection<InvoiceAttachments> InvoiceAttachments { get; set; }
        public ICollection<LinkedReturnStock> LinkedReturnStock { get; set; }
        public ICollection<LqAllocation> LqAllocation { get; set; }
        public ICollection<OrderCustomerNotes> OrderCustomerNotes { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
        public ICollection<OrderNotes> OrderNotes { get; set; }
        public ICollection<OrderQuery> OrderQuery { get; set; }
        public ICollection<OrderTracking> OrderTracking { get; set; }
        public ICollection<Packaging> Packaging { get; set; }
        public ICollection<PaymentInformation> PaymentInformation { get; set; }
        public ICollection<PrintJobs> PrintJobs { get; set; }
    }
}

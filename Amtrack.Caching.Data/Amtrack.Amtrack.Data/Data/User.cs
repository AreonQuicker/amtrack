using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack.Data.Data
{
    public partial class User
    {
        public User()
        {
            AccountManagerAccountsRepresentativeAccountsUser = new HashSet<AccountManagerAccountsRepresentative>();
            AccountManagerLayoutArtistsAccountManager = new HashSet<AccountManagerLayoutArtists>();
            AccountManagerLayoutArtistsLayoutArtist = new HashSet<AccountManagerLayoutArtists>();
            ClBatchContents = new HashSet<ClBatchContents>();
            CreditNoteAuthorizer = new HashSet<CreditNoteAuthorizer>();
            CreditNoteRequester = new HashSet<CreditNoteRequester>();
            CsStockTake = new HashSet<CsStockTake>();
            EmbroideryQuoteRequest = new HashSet<EmbroideryQuoteRequest>();
            FaultyGoodsRequestsClosedByNavigation = new HashSet<FaultyGoodsRequests>();
            FaultyGoodsRequestsFullfilledByNavigation = new HashSet<FaultyGoodsRequests>();
            FaultyGoodsRequestsRequestedByNavigation = new HashSet<FaultyGoodsRequests>();
            JobCardQueryAuthorNavigation = new HashSet<JobCardQuery>();
            JobCardQueryResolvedByNavigation = new HashSet<JobCardQuery>();
            LayoutArtists = new HashSet<LayoutArtists>();
            LdmAdjustmentTrackings = new HashSet<LdmAdjustmentTrackings>();
            LeadTimesJobCard = new HashSet<LeadTimesJobCard>();
            LinkedReturnStock = new HashSet<LinkedReturnStock>();
            LqAllocation = new HashSet<LqAllocation>();
            LqQueueAccessFkAccessedBy = new HashSet<LqQueueAccess>();
            LqQueueAccessFkForUser = new HashSet<LqQueueAccess>();
            LqQueueTracking = new HashSet<LqQueueTracking>();
            Notes = new HashSet<Notes>();
            OrderQueryAuthorNavigation = new HashSet<OrderQuery>();
            OrderQueryResolvedByNavigation = new HashSet<OrderQuery>();
            PrintDepartmentUsers = new HashSet<PrintDepartmentUsers>();
            QueryNotifications = new HashSet<QueryNotifications>();
            SalesRepresentatives = new HashSet<SalesRepresentatives>();
            SystemRequest = new HashSet<SystemRequest>();
            SystemRequestNote = new HashSet<SystemRequestNote>();
            UserTracking = new HashSet<UserTracking>();
        }

        public long Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public Guid Guid { get; set; }
        public byte[] Checksum { get; set; }
        public string Barcode { get; set; }
        public string AccountManagerCode { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string DisplayName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int Status { get; set; }
        public bool IsDefaultSalesRepresentative { get; set; }

        public AccountManagerAccountsRepresentative AccountManagerAccountsRepresentativeAccountManager { get; set; }
        public ExUser ExUser { get; set; }
        public SecurityLevels SecurityLevels { get; set; }
        public ICollection<AccountManagerAccountsRepresentative> AccountManagerAccountsRepresentativeAccountsUser { get; set; }
        public ICollection<AccountManagerLayoutArtists> AccountManagerLayoutArtistsAccountManager { get; set; }
        public ICollection<AccountManagerLayoutArtists> AccountManagerLayoutArtistsLayoutArtist { get; set; }
        public ICollection<ClBatchContents> ClBatchContents { get; set; }
        public ICollection<CreditNoteAuthorizer> CreditNoteAuthorizer { get; set; }
        public ICollection<CreditNoteRequester> CreditNoteRequester { get; set; }
        public ICollection<CsStockTake> CsStockTake { get; set; }
        public ICollection<EmbroideryQuoteRequest> EmbroideryQuoteRequest { get; set; }
        public ICollection<FaultyGoodsRequests> FaultyGoodsRequestsClosedByNavigation { get; set; }
        public ICollection<FaultyGoodsRequests> FaultyGoodsRequestsFullfilledByNavigation { get; set; }
        public ICollection<FaultyGoodsRequests> FaultyGoodsRequestsRequestedByNavigation { get; set; }
        public ICollection<JobCardQuery> JobCardQueryAuthorNavigation { get; set; }
        public ICollection<JobCardQuery> JobCardQueryResolvedByNavigation { get; set; }
        public ICollection<LayoutArtists> LayoutArtists { get; set; }
        public ICollection<LdmAdjustmentTrackings> LdmAdjustmentTrackings { get; set; }
        public ICollection<LeadTimesJobCard> LeadTimesJobCard { get; set; }
        public ICollection<LinkedReturnStock> LinkedReturnStock { get; set; }
        public ICollection<LqAllocation> LqAllocation { get; set; }
        public ICollection<LqQueueAccess> LqQueueAccessFkAccessedBy { get; set; }
        public ICollection<LqQueueAccess> LqQueueAccessFkForUser { get; set; }
        public ICollection<LqQueueTracking> LqQueueTracking { get; set; }
        public ICollection<Notes> Notes { get; set; }
        public ICollection<OrderQuery> OrderQueryAuthorNavigation { get; set; }
        public ICollection<OrderQuery> OrderQueryResolvedByNavigation { get; set; }
        public ICollection<PrintDepartmentUsers> PrintDepartmentUsers { get; set; }
        public ICollection<QueryNotifications> QueryNotifications { get; set; }
        public ICollection<SalesRepresentatives> SalesRepresentatives { get; set; }
        public ICollection<SystemRequest> SystemRequest { get; set; }
        public ICollection<SystemRequestNote> SystemRequestNote { get; set; }
        public ICollection<UserTracking> UserTracking { get; set; }
    }
}

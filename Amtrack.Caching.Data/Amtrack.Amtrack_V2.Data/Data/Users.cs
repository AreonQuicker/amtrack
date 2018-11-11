using System;
using System.Collections.Generic;

namespace Amtrack.Amtrack_V2.Data.Data
{
    public partial class Users
    {
        public Users()
        {
            Accounts = new HashSet<Accounts>();
            AsmDevice = new HashSet<AsmDevice>();
            AsmDeviceOperators = new HashSet<AsmDeviceOperators>();
            BrandingConversionGroups = new HashSet<BrandingConversionGroups>();
            BrandingConversionMembers = new HashSet<BrandingConversionMembers>();
            InverseUserUser = new HashSet<Users>();
            OneTimeTokens = new HashSet<OneTimeTokens>();
            PodCollectionNote = new HashSet<PodCollectionNote>();
            PodDispatchBuzzerAllocationTracking = new HashSet<PodDispatchBuzzerAllocationTracking>();
            UserBranches = new HashSet<UserBranches>();
            UserDepartment = new HashSet<UserDepartment>();
            UserSecurityPermission = new HashSet<UserSecurityPermission>();
        }

        public Guid UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public string Barcode { get; set; }
        public string SalesmanCode { get; set; }
        public string TrackingCode { get; set; }
        public string PhoneDirect { get; set; }
        public string PhoneMobile { get; set; }
        public long Status { get; set; }
        public long Flags { get; set; }
        public Guid? SecurityLevelSecurityLevelId { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public Guid? UserUserId { get; set; }
        public string Fax2Email { get; set; }
        public string EmployeeCode { get; set; }
        public string ScaleUsername { get; set; }
        public string ScalePassword { get; set; }
        public string ScaleServer { get; set; }
        public string ScaleDomain { get; set; }
        public int? ScaleDeviceScanSuffix { get; set; }
        public string ScaleClientUrl { get; set; }

        public SecurityLevels SecurityLevelSecurityLevel { get; set; }
        public Users UserUser { get; set; }
        public ICollection<Accounts> Accounts { get; set; }
        public ICollection<AsmDevice> AsmDevice { get; set; }
        public ICollection<AsmDeviceOperators> AsmDeviceOperators { get; set; }
        public ICollection<BrandingConversionGroups> BrandingConversionGroups { get; set; }
        public ICollection<BrandingConversionMembers> BrandingConversionMembers { get; set; }
        public ICollection<Users> InverseUserUser { get; set; }
        public ICollection<OneTimeTokens> OneTimeTokens { get; set; }
        public ICollection<PodCollectionNote> PodCollectionNote { get; set; }
        public ICollection<PodDispatchBuzzerAllocationTracking> PodDispatchBuzzerAllocationTracking { get; set; }
        public ICollection<UserBranches> UserBranches { get; set; }
        public ICollection<UserDepartment> UserDepartment { get; set; }
        public ICollection<UserSecurityPermission> UserSecurityPermission { get; set; }
    }
}

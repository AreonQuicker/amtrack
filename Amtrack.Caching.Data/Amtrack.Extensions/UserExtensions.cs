using Amtrack.Amtrack.Data.Data;
using Amtrack.Amtrack_V2.Data.Data;
using Amtrack.ValueObjects.Security;
using Amtrack.ValueObjects.Users;

namespace Amtrack.Extensions
{
	public static class UserExtensions
	{
		public static UserVO ToUserVo(this Users user)
		{
			return new UserVO()
			{
				Barcode = user.Barcode
			  ,
				DirectNumber = user.PhoneDirect
			  ,
				MobileNumber = user.PhoneMobile
			  ,
				EmployeeCode = user.EmployeeCode
			  ,
				Firstname = user.Firstname
			  ,
				Lastname = user.Lastname
			  ,
				Username = user.Username
			  ,
				UserId = user.UserId
			  ,
				Flags = (Enumeration.UserFlags)user.Flags
			  ,
				PrimaryEmailAddress = user.PrimaryEmail
			  ,
				SecondaryEmailAddress = user.SecondaryEmail
			  ,
				SalesmanCode = user.SalesmanCode
			  ,
				SCALE_ClientUrl = user.ScaleClientUrl
			  ,
				SCALE_Domain = user.ScaleDomain
			  ,
				SCALE_Password = user.ScalePassword
			  ,
				SCALE_Server = user.ScaleServer
			  ,
				SCALE_Username = user.ScaleUsername
			  ,
				Status = (Enumeration.UserStatusCodes)user.Status
			  ,
				TrackingCode = user.TrackingCode
			  ,
				SCALE_DataSuffix = (Enumeration.SCALEDataSuffixTypes)(user.ScaleDeviceScanSuffix ?? 0)
			  ,
				ParentUser = user.UserUser?.ToUserVo()
			};
		}

		public static SecurityLevelVO ToSecurityLevelVo(this Permission permission)
		{
			return new SecurityLevelVO()
			{
				DateCreated = permission.Created,
				DateLastModified = permission.Modified,
				Group = permission.Group,
				Name = permission.Name,
				Id = (int)permission.Id,
				SecurityLevelGuid = permission.Guid
			};
		}
	}
}

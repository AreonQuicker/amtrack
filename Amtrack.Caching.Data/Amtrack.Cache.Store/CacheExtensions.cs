using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace Amtrack.Cache.Store
{
	public static class CacheExtensions
	{
		public static string ObjectToString(this object obj)
		{
			return JsonConvert.SerializeObject(obj);
		}

		public static T StringToObject<T>(this string serialized)
		{
			return JsonConvert.DeserializeObject<T>(serialized);
		}

		public static byte[] ObjectToByteArray(this object obj)
		{
			if(obj == null)
				return null;

			BinaryFormatter bf = new BinaryFormatter();

			using(MemoryStream ms = new MemoryStream())
			{
				bf.Serialize(ms, obj);

				return ms.ToArray();
			}
		}

		public static T ByteArrayToObject<T>(this byte[] arrBytes)
		{
			MemoryStream memStream = new MemoryStream();
			BinaryFormatter binForm = new BinaryFormatter();

			memStream.Write(arrBytes, 0, arrBytes.Length);
			memStream.Seek(0, SeekOrigin.Begin);

			var obj = (T)binForm.Deserialize(memStream);

			return obj;
		}

		public static string GetValue(this object value, string property)
		{
			var eProperty = value.GetType()?.GetProperty(property, typeof(string));

			if(eProperty != null)
				return eProperty.GetValue(value)?.ToString();

			return null;
		}

		public static bool GetValue(this object value, string property, out string propertyValue)
		{
			propertyValue = value.GetValue(property);

			if(!string.IsNullOrEmpty(propertyValue))
				return true;

			return false;
		}
	}
}

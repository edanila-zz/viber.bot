using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Viber user details.
	/// </summary>
	public class UserDetails : User
	{
		/// <summary>
		/// The operating system type and version of the user’s primary device.
		/// </summary>
		[JsonProperty("primary_device_os")]
		public string PrimaryDeviceOS { get; set; }

		/// <summary>
		/// The Viber version installed on the user’s primary device.
		/// </summary>
		[JsonProperty("viber_version")]
		public string ViberVersion { get; set; }

		/// <summary>
		/// Mobile country code.
		/// </summary>
		[JsonProperty("mcc")]
		public int Mcc { get; set; }

		/// <summary>
		/// Mobile network code.
		/// </summary>
		[JsonProperty("mnc")]
		public int Mnc { get; set; }

		/// <summary>
		/// The user’s device type.
		/// </summary>
		[JsonProperty("device_type")]
		public string DeviceType { get; set; }
	}
}
using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Viber user.
	/// </summary>
	public class User : UserBase
	{
		/// <summary>
		/// Unique Viber user id.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// User’s 2 letter country code.
		/// </summary>
		[JsonProperty("country")]
		public string Country { get; set; }

		/// <summary>
		/// User’s phone language.
		/// </summary>
		[JsonProperty("language")]
		public string Language { get; set; }

		/// <summary>
		/// Max API version, matching the most updated user’s device.
		/// </summary>
		[JsonProperty("api_version")]
		public double ApiVersion { get; set; }
	}
}
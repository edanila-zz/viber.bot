using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Contact object.
	/// </summary>
	public class Contact
	{
		/// <summary>
		/// Name of the contact. Max 28 characters.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Phone number of the contact. Max 18 characters.
		/// </summary>
		[JsonProperty("phone_number")]
		public string TN { get; set; }
	}
}
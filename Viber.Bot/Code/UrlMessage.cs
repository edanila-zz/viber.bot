using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Url message.
	/// </summary>
	public class UrlMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="UrlMessage"/> class.
		/// </summary>
		public UrlMessage()
			: base(MessageType.Url)
		{
		}

		/// <summary>
		/// URL, max 2000 characters.
		/// </summary>
		[JsonProperty("media")]
		public string Media { get; set; }
	}
}
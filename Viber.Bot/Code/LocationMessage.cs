using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Location message.
	/// </summary>
	public class LocationMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LocationMessage"/> class.
		/// </summary>
		public LocationMessage()
			: base(MessageType.Location)
		{
		}

		/// <summary>
		/// Location data.
		/// </summary>
		[JsonProperty("location")]
		public Location Location { get; set; }
	}
}
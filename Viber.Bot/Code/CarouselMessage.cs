using Newtonsoft.Json;
using System.Collections.Generic;

namespace Viber.Bot
{
	/// <summary>
	/// CarouselMessage message.
	/// </summary>
	public class CarouselMessage : MessageBase
    {
		/// <summary>
		/// Initializes a new instance of the <see cref="CarouselMessage"/> class.
		/// </summary>
		public CarouselMessage()
			: base(MessageType.CarouselContent)
		{
		}

		/// <summary>
		/// Backward compatibility text, limited to 7,000 characters
		/// </summary>
		[JsonProperty("alt_text")]
		public string AltText { get; set; }

		/// <summary>
		/// Carousel object.
		/// </summary>
		[JsonProperty("rich_media")]
		public Carousel Carousel { get; set; }
	}
}
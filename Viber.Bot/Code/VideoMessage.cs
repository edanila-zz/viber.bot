using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Video message.
	/// </summary>
	public class VideoMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="VideoMessage"/> class.
		/// </summary>
		public VideoMessage()
			: base(MessageType.Video)
		{
		}

		/// <summary>
		/// URL of the video (MP4, H264). Max size 50 MB. Only MP4 and H264 are supported.
		/// </summary>
		[JsonProperty("media")]
		public string Media { get; set; }

		/// <summary>
		/// URL of a reduced size image (JPEG). Max size 100 kb. Recommended: 400x400. Only JPEG format is supported.
		/// </summary>
		[JsonProperty("thumbnail")]
		public string Thumbnail { get; set; }

		/// <summary>
		/// Size of the video in bytes.
		/// </summary>
		[JsonProperty("size")]
		public int Size { get; set; }

		/// <summary>
		/// Video duration in seconds; will be displayed to the receiver. Max 180 seconds.
		/// </summary>
		[JsonProperty("duration")]
		public int? Duration { get; set; }
	}
}
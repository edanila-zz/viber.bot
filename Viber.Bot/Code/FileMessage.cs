using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// File message.
	/// </summary>
	public class FileMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="FileMessage"/> class.
		/// </summary>
		public FileMessage()
			: base(MessageType.File)
		{
		}

		/// <summary>
		/// URL of the file. Max size 50 MB. See forbidden file formats for unsupported file types
		/// </summary>
		[JsonProperty("media")]
		public string Media { get; set; }

		/// <summary>
		/// Size of the file in bytes.
		/// </summary>
		[JsonProperty("size")]
		public int Size { get; set; }

		/// <summary>
		/// Name of the file. File name should include extension. Max 256 characters (including file extension). Sending a file without extension or with the wrong extension might cause the client to be unable to open the file.
		/// </summary>
		[JsonProperty("file_name")]
		public string FileName { get; set; }
	}
}
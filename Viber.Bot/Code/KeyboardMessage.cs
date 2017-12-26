using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Keyboard message.
	/// </summary>
	public class KeyboardMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="KeyboardMessage"/> class.
		/// </summary>
		public KeyboardMessage()
			: base(MessageType.Text)
		{
		}

		/// <summary>
		/// The text of the message.
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// Keyboard object.
		/// </summary>
		[JsonProperty("keyboard")]
		public Keyboard Keyboard { get; set; }
	}
}
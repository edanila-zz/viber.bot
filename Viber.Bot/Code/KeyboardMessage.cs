using Newtonsoft.Json;
using System;

namespace Viber.Bot
{
	/// <summary>
	/// Keyboard message.
	/// </summary>
	[Obsolete("KeyboardMessage is deprecated, please use property MessageBase.Keyboard instead.")]
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

	}
}
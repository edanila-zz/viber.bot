using Newtonsoft.Json;
using System.Collections.Generic;

namespace Viber.Bot
{
	/// <summary>
	/// Broadcast message.
	/// </summary>
	public class BroadcastMessage : MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="BroadcastMessage"/> class.
		/// </summary>
		public BroadcastMessage()
			: base(MessageType.Text)
		{
		}

		/// <summary>
		/// The text of the message.
		/// </summary>
		[JsonProperty("text")]
		public string Text { get; set; }

		/// <summary>
		/// The list of accounts identifiers to send messages to multiple Viber users (who subscribed to the account).
		/// </summary>
		[JsonProperty("broadcast_list")]
		public IList<string> BroadcastList { get; set; }
	}
}
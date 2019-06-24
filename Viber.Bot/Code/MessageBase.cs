using System.Collections.Generic;
using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Base message info.
	/// </summary>
	public abstract class MessageBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MessageBase"/> class.
		/// </summary>
		/// <param name="type">Message type.</param>
		protected MessageBase(MessageType type)
		{
			Type = type;
		}

		/// <summary>
		/// Unique Viber user id.
		/// </summary>
		[JsonProperty("receiver")]
		public string Receiver { get; set; }

		/// <summary>
		/// Message type.
		/// </summary>
		[JsonProperty("type")]
		public MessageType Type { get; }

		/// <summary>
		/// Sender of the message.
		/// </summary>
		[JsonProperty("sender")]
		public UserBase Sender { get; set; }

		/// <summary>
		/// Allow the account to track messages and user’s replies. Sent tracking_data value will be passed back with user’s reply.
		/// </summary>
		[JsonProperty("tracking_data")]
		public string TrackingData { get; set; }

		/// <summary>
		/// Minimal API version required by clients for this message (default 1).
		/// </summary>
		[JsonProperty("min_api_version")]
		public double? MinApiVersion { get; set; }
    }
}
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Viber.Bot
{
	/// <summary>
	/// Event types.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EventType
	{
		/// <summary>
		/// Event 'delivered'.
		/// </summary>
		[EnumMember(Value = "delivered")]
		Delivered = 1,

		/// <summary>
		/// Event 'seen'.
		/// </summary>
		[EnumMember(Value = "seen")]
		Seen = 2,

		/// <summary>
		/// Event 'failed'.
		/// </summary>
		[EnumMember(Value = "failed")]
		Failed = 3,

		/// <summary>
		/// Event 'subscribed'.
		/// </summary>
		[EnumMember(Value = "subscribed")]
		Subscribed = 4,

		/// <summary>
		/// Event 'unsubscribed'.
		/// </summary>
		[EnumMember(Value = "unsubscribed")]
		Unsubscribed = 5,

		/// <summary>
		/// Event 'conversation_started'.
		/// </summary>
		[EnumMember(Value = "conversation_started")]
		ConversationStarted = 6,

		/// <summary>
		/// Event 'message'.
		/// </summary>
		[EnumMember(Value = "message")]
		Message = 7,

		/// <summary>
		/// Event 'webhook'.
		/// </summary>
		[EnumMember(Value = "webhook")]
		Webhook = 8,

		/// <summary>
		/// Event 'action'.
		/// </summary>
		[EnumMember(Value = "action")]
		Action = 9,

		/// <summary>
		/// Event 'client_status'.
		/// </summary>
		[EnumMember(Value = "client_status")]
		ClientStatus = 10
	}
}
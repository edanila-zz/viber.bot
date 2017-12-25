using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Chat member.
	/// </summary>
	public class ChatMember : UserBase
	{
		/// <summary>
		/// Unique Viber user id.
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// Chat member role.
		/// </summary>
		[JsonProperty("role")]
		public ChatMemberRole Role { get; set; }
	}
}
using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Get User Details response.
	/// </summary>
	internal class GetUserDetailsResponse : ApiResponseBase
	{
		/// <summary>
		/// Unique id of the message.
		/// </summary>
		/// <remarks>API nothing returns.</remarks>
		[JsonProperty("message_token")]
		public long MessageToken { get; set; }

		/// <summary>
		/// User details.
		/// </summary>
		[JsonProperty("user")]
		public UserDetails User { get; set; }
	}
}
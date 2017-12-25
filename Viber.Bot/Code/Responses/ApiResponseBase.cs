using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Base API response.
	/// </summary>
	internal abstract class ApiResponseBase
	{
		/// <summary>
		/// Action result.
		/// </summary>
		[JsonProperty("status")]
		public ErrorCode Status { get; set; }

		/// <summary>
		/// Ok or failure reason.
		/// </summary>
		[JsonProperty("status_message")]
		public string StatusMessage { get; set; }
	}
}
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Set webhook Response.
	/// </summary>
	internal class SetWebhookResponse : ApiResponseBase
	{
		/// <summary>
		/// List of event types you will receive a callback for. Should return the same values sent in the request.
		/// </summary>
		[JsonProperty("event_types")]
		public ICollection<EventType> EventTypes { get; set; }
	}
}
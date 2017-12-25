using System.Collections.Generic;

using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Get Account Info response.
	/// </summary>
	internal class GetAccountInfoResponse : ApiResponseBase, IAccountInfo
	{
		/// <inheritdoc />
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <inheritdoc />
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <inheritdoc />
		[JsonProperty("uri")]
		public string Uri { get; set; }

		/// <inheritdoc />
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <inheritdoc />
		[JsonProperty("background")]
		public string Background { get; set; }

		/// <inheritdoc />
		[JsonProperty("category")]
		public string Category { get; set; }

		/// <inheritdoc />
		[JsonProperty("subcategory")]
		public string Subcategory { get; set; }

		/// <inheritdoc />
		[JsonProperty("event_types")]
		public ICollection<EventType> EventTypes { get; set; }

		/// <inheritdoc />
		[JsonProperty("location")]
		public Location Location { get; set; }

		/// <inheritdoc />
		[JsonProperty("country")]
		public string Country { get; set; }

		/// <inheritdoc />
		[JsonProperty("webhook")]
		public string Webhook { get; set; }

		/// <inheritdoc />
		[JsonProperty("subscribers_count")]
		public long SubscribersCount { get; set; }

		/// <inheritdoc />
		[JsonProperty("members")]
		public ICollection<ChatMember> Members { get; set; }
	}
}
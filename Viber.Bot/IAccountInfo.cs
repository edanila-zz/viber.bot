using System.Collections.Generic;

namespace Viber.Bot
{
	/// <summary>
	/// Get Account Info response.
	/// </summary>
	public interface IAccountInfo
	{
		/// <summary>
		/// Unique numeric id of the account.
		/// </summary>
		string Id { get; }

		/// <summary>
		/// Account name.
		/// </summary>
		string Name { get; }

		/// <summary>
		/// Unique URI of the Account.
		/// </summary>
		string Uri { get; }

		/// <summary>
		/// Account icon URL.
		/// </summary>
		string Icon { get; }

		/// <summary>
		/// Conversation background URL.
		/// </summary>
		string Background { get; }

		/// <summary>
		/// Account category.
		/// </summary>
		string Category { get; }

		/// <summary>
		/// Account sub-category.
		/// </summary>
		string Subcategory { get; }

		/// <summary>
		/// List of event types you will receive a callback for. Should return the same values sent in the request.
		/// </summary>
		ICollection<EventType> EventTypes { get; }

		/// <summary>
		/// Account location (coordinates). Will be used for finding accounts near me.
		/// </summary>
		Location Location { get; }

		/// <summary>
		/// Account country.
		/// </summary>
		string Country { get; }

		/// <summary>
		/// Account registered webhook.
		/// </summary>
		string Webhook { get; }

		/// <summary>
		/// Number of subscribers.
		/// </summary>
		long SubscribersCount { get; }

		/// <summary>
		/// Public Chat members. Public Accounts only.
		/// </summary>
		ICollection<ChatMember> Members { get; }
	}
}
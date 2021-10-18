using System.Collections.Generic;
using System.Threading.Tasks;

namespace Viber.Bot
{
	/// <summary>
	/// Viber API.
	/// </summary>
	public interface IViberBotClient
	{
		/// <summary>
		/// Setting the webhook.
		/// </summary>
		/// <param name="url">Account webhook URL to receive callbacks &amp; messages from users.</param>
		/// <param name="eventTypes">Indicates the types of Viber events that the account owner would like to be notified about. Don’t include this parameter in your request to get all events.</param>
		/// <returns>Collection of <see cref="EventType"/>.</returns>
		Task<ICollection<EventType>> SetWebhookAsync(string url, ICollection<EventType> eventTypes = null);

		/// <summary>
		/// The account’s details as registered in Viber. The account admin will be able to edit most of these details from his Viber client.
		/// </summary>
		/// <returns>The account’s details as registered in Viber.</returns>
		Task<IAccountInfo> GetAccountInfoAsync();

		/// <summary>
		/// The details of a specific Viber user based on his unique user ID. The user ID can be obtained from the callbacks sent to the account regarding user’s actions. This request can be sent twice during a 12 hours period for each user ID.
		/// </summary>
		/// <param name="id">Unique Viber user id.</param>
		/// <returns>The details of a specific Viber user based on his unique user ID.</returns>
		Task<UserDetails> GetUserDetailsAsync(string id);

		/// <summary>
		/// Sends <see cref="TextMessage"/> to Viber user.
		/// </summary>
		/// <param name="message">Instance of <see cref="TextMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendTextMessageAsync(TextMessage message);

		/// <summary>
		/// Sends <see cref="PictureMessage"/> to Viber user.
		/// </summary>
		/// <param name="message">Instance of <see cref="PictureMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendPictureMessageAsync(PictureMessage message);

		/// <summary>
		/// Sends <see cref="FileMessage"/> to Viber user.
		/// </summary>
		/// <param name="message">Instance of <see cref="FileMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendFileMessageAsync(FileMessage message);

		/// <summary>
		/// Sends <see cref="VideoMessage"/> to Viber user.
		/// </summary>
		/// <param name="message">Instance of <see cref="VideoMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendVideoMessageAsync(VideoMessage message);

		/// <summary>
		/// Sends <see cref="ContactMessage"/> to Viber user.
		/// </summary>
		/// <param name="message">Instance of <see cref="ContactMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendContactMessageAsync(ContactMessage message);

		/// <summary>
		/// Sends <see cref="LocationMessage"/> to Viber user.
		/// </summary>
		/// <param name="message">Instance of <see cref="LocationMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendLocationMessageAsync(LocationMessage message);

		/// <summary>
		/// Sends <see cref="UrlMessage"/> to Viber user.
		/// </summary>
		/// <param name="message">Instance of <see cref="UrlMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendUrlMessageAsync(UrlMessage message);

		/// <summary>
		/// Sends <see cref="StickerMessage"/> to Viber user.
		/// </summary>
		/// <param name="message">Instance of <see cref="StickerMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendStickerMessageAsync(StickerMessage message);

		/// <summary>
		/// Sends <see cref="KeyboardMessage"/> to Viber user.
		/// </summary>
		/// <param name="message">Instance of <see cref="KeyboardMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendKeyboardMessageAsync(KeyboardMessage message);

		/// <summary>
		/// Sends broadcast message to Viber users.
		/// </summary>
		/// <param name="message">Instance of <see cref="BroadcastMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendBroadcastMessageAsync(BroadcastMessage message);

		/// <summary>
		/// Sends carousel message to Viber user.
		/// </summary>
		/// <param name="message">Instance of <see cref="CarouselMessage"/>.</param>
		/// <returns>Message token.</returns>
		Task<long> SendCarouselMessageAsync(CarouselMessage message);

		/// <summary>
		/// Validate hash.
		/// </summary>
		/// <param name="signatureHeader">Value of "X-Viber-Content-Signature" header.</param>
		/// <param name="jsonMessage">JSON message.</param>
		/// <returns><c>true</c> if valid.</returns>
		bool ValidateWebhookHash(string signatureHeader, string jsonMessage);
	}
}
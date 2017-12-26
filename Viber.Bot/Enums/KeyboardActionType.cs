using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Viber.Bot
{
	/// <summary>
	/// Keyboard action type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum KeyboardActionType
	{
		/// <summary>
		/// The value of ActionBody is sent as a text message to account.
		/// </summary>
		[EnumMember(Value = "reply")]
		Reply = 1,

		/// <summary>
		/// The value of ActionBody is opened in the browser.
		/// </summary>
		[EnumMember(Value = "open-url")]
		OpenUrl = 2,

		/// <summary>
		/// The client will share be able to share their location via a <see cref="LocationMessage"/> object.
		/// </summary>
		[EnumMember(Value = "location-picker")]
		LocationPicker = 3,

		/// <summary>
		/// The client will share be able to share its phone number via a <see cref="ContactMessage"/> object.
		/// </summary>
		[EnumMember(Value = "share-phone")]
		SharePhone = 4,

		/// <summary>
		/// Nothing is sent to the user or account. Just an informative button.
		/// </summary>
		[EnumMember(Value = "none")]
		None = 5
	}
}
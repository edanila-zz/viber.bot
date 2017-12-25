using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Viber.Bot
{
	/// <summary>
	/// Message type.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MessageType
	{
		/// <summary>
		/// Message 'text'.
		/// </summary>
		[EnumMember(Value = "text")]
		Text = 1,

		/// <summary>
		/// Message 'picture'.
		/// </summary>
		[EnumMember(Value = "picture")]
		Picture = 2,

		/// <summary>
		/// Message 'video'.
		/// </summary>
		[EnumMember(Value = "video")]
		Video = 3,

		/// <summary>
		/// Message 'file'.
		/// </summary>
		[EnumMember(Value = "file")]
		File = 4,

		/// <summary>
		/// Message 'location'.
		/// </summary>
		[EnumMember(Value = "location")]
		Location = 5,

		/// <summary>
		/// Message 'contact'.
		/// </summary>
		[EnumMember(Value = "contact")]
		Contact = 6,

		/// <summary>
		/// Message 'sticker'.
		/// </summary>
		[EnumMember(Value = "sticker")]
		Sticker = 7,

		/// <summary>
		/// Message 'rich_media'.
		/// </summary>
		[EnumMember(Value = "rich_media")]
		CarouselContent = 8,

		/// <summary>
		/// Message 'url'.
		/// </summary>
		[EnumMember(Value = "url")]
		Url = 9
	}
}
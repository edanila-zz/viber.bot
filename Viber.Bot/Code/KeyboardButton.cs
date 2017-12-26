using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Keyboard button.
	/// </summary>
	public class KeyboardButton
	{
		/// <summary>
		/// Type of action pressing the button will perform.
		/// </summary>
		/// <remarks>Default value: <see cref="KeyboardActionType.Reply"/>.</remarks>
		[JsonProperty("ActionType")]
		public KeyboardActionType? ActionType { get; set; }

		/// <summary>
		/// Text for 'reply' and 'none'. ActionType or URL for 'open-url'.
		/// </summary>
		/// <remarks>For ActionType 'reply' - text. For ActionType 'open-url' - Valid URL.</remarks>
		[JsonProperty("ActionBody")]
		public string ActionBody { get; set; }

		/// <summary>
		/// Text to be displayed on the button. Can contain some HTML tags.
		/// </summary>
		/// <remarks>
		/// Free text. Valid and allowed HTML tags Max 250 characters.
		/// If the text is too long to display on the button it will be cropped and ended with "…".
		/// </remarks>
		[JsonProperty("Text")]
		public string Text { get; set; }

		/// <summary>
		/// Button width in columns.
		/// </summary>
		/// <remarks>Possible values: 1-6. Default value: 6.</remarks>
		[JsonProperty("Columns")]
		public int? Columns { get; set; }

		/// <summary>
		/// Button height in rows.
		/// </summary>
		/// <remarks>Possible values: 1-2. Default value: 1.</remarks>
		[JsonProperty("Rows")]
		public int? Rows { get; set; }

		/// <summary>
		/// Background color of button (valid color HEX value).
		/// </summary>
		[JsonProperty("BgColor")]
		public string BackgroundColor { get; set; }

		/// <summary>
		/// Determine whether the user action is presented in the conversation.
		/// </summary>
		[JsonProperty("Silent")]
		public bool? Silent { get; set; }

		/// <summary>
		/// Type of the background media.
		/// </summary>
		/// <remarks>
		/// Default value: <see cref="Viber.Bot.BackgroundMediaType.Picture"/>.
		/// Max size: 500 kb.
		/// </remarks>
		[JsonProperty("BgMediaType")]
		public BackgroundMediaType? BackgroundMediaType { get; set; }

		/// <summary>
		/// URL for background media content (picture or gif). Will be placed with aspect to fill logic.
		/// </summary>
		[JsonProperty("BgMedia")]
		public string BackgroundMedia { get; set; }

		/// <summary>
		/// When true - animated background media (gif) will loop continuously. When false - animated background media will play once and stop.
		/// </summary>
		/// <remarks>Default value: true.</remarks>
		[JsonProperty("BgLoop")]
		public bool? BackgroundLoop { get; set; }

		/// <summary>
		/// URL of image to place on top of background (if any).
		/// Can be a partially transparent image that will allow showing some of the background.
		/// Will be placed with aspect to fill logic.
		/// </summary>
		/// <remarks>JPEG and PNG files are supported. Max size: 500 kb.</remarks>
		[JsonProperty("Image")]
		public string Image { get; set; }

		/// <summary>
		/// Vertical alignment of the text.
		/// </summary>
		/// <remarks>Default value: <see cref="Viber.Bot.TextVerticalAlign.Middle"/>.</remarks>
		[JsonProperty("TextVAlign")]
		public TextVerticalAlign? TextVerticalAlign { get; set; }

		/// <summary>
		/// Horizontal align of the text.
		/// </summary>
		/// <remarks>Default value: <see cref="Viber.Bot.TextHorizontalAlign.Center"/>.</remarks>
		[JsonProperty("TextHAlign")]
		public TextHorizontalAlign? TextHorizontalAlign { get; set; }

		/// <summary>
		/// Custom paddings for the text in points. The value is an array of Integers [top, left, bottom, right].
		/// </summary>
		/// <remarks>Possible values: per padding 0-12. Default value: [12,12,12,12].</remarks>
		[JsonProperty("TextPaddings")]
		public int[] TextPaddings { get; set; }

		/// <summary>
		/// Text opacity.
		/// </summary>
		/// <remarks>Possible values: 0-100. Default value: 100.</remarks>
		[JsonProperty("TextOpacity")]
		public int? TextOpacity { get; set; }

		/// <summary>
		/// Text size out of 3 available options.
		/// </summary>
		/// <remarks>Default value: <see cref="Viber.Bot.TextSize.Regular"/>.</remarks>
		[JsonProperty("TextSize")]
		public TextSize? TextSize { get; set; }

		/// <summary>
		/// Determine the open-url action result, in app or external browser.
		/// </summary>
		/// <remarks>Default value: <see cref="OpenUrlType.Internal"/>.</remarks>
		[JsonProperty("OpenURLType")]
		public OpenUrlType? UrlOpenType { get; set; }

		/// <summary>
		/// Determine the url media type.
		/// </summary>
		/// <remarks>Default value: <see cref="OpenUrlMediaType.NotMedia"/>.</remarks>
		[JsonProperty("OpenURLMediaType")]
		public OpenUrlMediaType? UrlMediaType { get; set; }

		/// <summary>
		/// Background gradient to use under text, Works only when TextVAlign is equal to top or bottom	Hex value (6 characters)
		/// </summary>
		[JsonProperty("TextBgGradientColor")]
		public string TextBackgroundGradientColor { get; set; }
	}
}
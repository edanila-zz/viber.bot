using Newtonsoft.Json;
using System.Collections.Generic;

namespace Viber.Bot
{
	/// <summary>
	/// Carousel message.
	/// </summary>
	public class Carousel
	{
		/// <summary>
		/// Background color of the keyboard (valid color HEX value).
		/// </summary>
		[JsonProperty("BgColor")]
		public string BackgroundColor { get; set; }

		/// <summary>
		/// Number of columns per carousel content block.Default 6 columns
		/// </summary>
		[JsonProperty("ButtonsGroupColumns")]
		public int? ButtonsGroupColumns { get; set; }

		/// <summary>
		/// Number of rows per carousel content block.Default 7 rows
		/// </summary>
		[JsonProperty("ButtonsGroupRows")]
		public int? ButtonsGroupRows { get; set; }

		/// <summary>
		/// Const value.
		/// </summary>
		[JsonProperty("Type")]
		private const string Type = "rich_media";

		/// <summary>
		/// Array containing all keyboard buttons by order.
		/// </summary>
		[JsonProperty("Buttons")]
		public ICollection<KeyboardButton> Buttons { get; set; }
	}
}

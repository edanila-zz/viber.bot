using System.Collections.Generic;
using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Keyboard object.
	/// </summary>
	public class Keyboard
	{
		/// <summary>
		/// Const value.
		/// </summary>
		[JsonProperty("Type")]
		private const string Type = "keyboard";

		/// <summary>
		/// Array containing all keyboard buttons by order.
		/// </summary>
		[JsonProperty("Buttons")]
		public ICollection<KeyboardButton> Buttons { get; set; }

		/// <summary>
		/// When true - the keyboard will always be displayed with the same height as the native keyboard.
		/// When false - short keyboards will be displayed with the minimal possible height.
		/// Maximal height will be native keyboard height.
		/// </summary>
		[JsonProperty("DefaultHeight")]
		public bool DefaultHeight { get; set; }

		/// <summary>
		/// Background color of the keyboard (valid color HEX value).
		/// </summary>
		[JsonProperty("BgColor")]
		public string BackgroundColor { get; set; }

		/// <summary>
		/// How much percent of free screen space in chat should be taken by keyboard.
		/// The final height will be not less than height of system keyboard.
		/// </summary>
		/// <remarks>Possible values: 40-70.</remarks>
		[JsonProperty("CustomDefaultHeight")]
		public int? CustomDefaultHeight { get; set; }

		/// <summary>
		/// Allow use custom aspect ratio for Carousel content blocks.
		/// Scales the height of the default square block (which is defined on client side) to the given value in percents.
		/// It means blocks can become not square and it can be used to create rich messages with correct custom aspect ratio.
		/// This is applied to all blocks in the Carousel content.
		/// </summary>
		/// <remarks>Possible values: 20-100. Default value: 100.</remarks>
		[JsonProperty("HeightScale")]
		public int? HeightScale { get; set; }

		/// <summary>
		/// Represents size of block for grouping buttons during layout.
		/// </summary>
		/// <remarks>Possible values: 1-6. Default value: 6.</remarks>
		[JsonProperty("ButtonsGroupColumns")]
		public int? ButtonsGroupColumns { get; set; }

		/// <summary>
		/// Represents size of block for grouping buttons during layout.
		/// </summary>
		/// <remarks>Possible values: 1-7. Default value: 7 for Carousel content ; 2 for Keyboard.</remarks>
		[JsonProperty("ButtonsGroupRows")]
		public int? ButtonsGroupRows { get; set; }

		/// <summary>
		/// Customize the keyboard input field.
		/// </summary>
		[JsonProperty("InputFieldState")]
		public KeyboardInputFieldState? InputFieldState { get; set; }
	}
}

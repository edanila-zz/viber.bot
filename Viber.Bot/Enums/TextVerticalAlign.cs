using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Viber.Bot
{
	/// <summary>
	/// Vertical alignment of the text.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TextVerticalAlign
	{
		/// <summary>
		/// Align 'top'.
		/// </summary>
		[EnumMember(Value = "top")]
		Top = 1,

		/// <summary>
		/// Align 'middle'.
		/// </summary>
		[EnumMember(Value = "middle")]
		Middle = 2,

		/// <summary>
		/// Align 'bottom'.
		/// </summary>
		[EnumMember(Value = "bottom")]
		Bottom = 3
	}
}
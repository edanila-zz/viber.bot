using Newtonsoft.Json;

namespace Viber.Bot
{
	/// <summary>
	/// Base user info.
	/// </summary>
	public class UserBase : IUserBase
	{
		/// <inheritdoc />
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <inheritdoc />
		[JsonProperty("avatar")]
		public string Avatar { get; set; }
	}
}
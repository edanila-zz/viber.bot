namespace Viber.Bot
{
	/// <summary>
	/// Base user info.
	/// </summary>
	public interface IUserBase
	{
		/// <summary>
		/// User’s Viber name.
		/// </summary>
		string Name { get; set; }

		/// <summary>
		/// URL of the user’s avatar.
		/// </summary>
		string Avatar { get; set; }
	}
}
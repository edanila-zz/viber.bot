using System;

namespace Viber.Bot
{
	/// <summary>
	/// Viber request API exception.
	/// </summary>
	public class ViberRequestApiException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ViberRequestApiException"/> class.
		/// </summary>
		/// <param name="code">Error code.</param>
		/// <param name="message">The message that describes the error.</param>
		/// <param name="method">Method name.</param>
		/// <param name="request">Request data in JSON format.</param>
		/// <param name="response">Response data in JSON format.</param>
		public ViberRequestApiException(
			ErrorCode code,
			string message,
			string method,
			string request,
			string response) : base(message)
		{
			Code = Enum.IsDefined(typeof(ErrorCode), code) ? code : ErrorCode.GeneralError;
			Request = request;
			Method = method;
			Response = response;
		}

		/// <summary>
		/// Error code.
		/// </summary>
		public ErrorCode Code { get; }

		/// <summary>
		/// Method name.
		/// </summary>
		public string Method { get; }

		/// <summary>
		/// Request data in JSON format.
		/// </summary>
		public string Request { get; }

		/// <summary>
		/// Response data in JSON format.
		/// </summary>
		public string Response { get; }
	}
}
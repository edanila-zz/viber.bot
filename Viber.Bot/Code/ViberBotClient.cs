using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net;

namespace Viber.Bot
{
	/// <summary>
	/// Viber API.
	/// </summary>
	public class ViberBotClient : IViberBotClient, IDisposable
	{
		/// <summary>
		/// Header "X-Viber-Content-Signature".
		/// </summary>
		public const string XViberContentSignatureHeader = "X-Viber-Content-Signature";

		/// <summary>
		/// Header "X-Viber-Auth-Token".
		/// </summary>
		private const string XViberAuthTokenHeader = "X-Viber-Auth-Token";

		/// <summary>
		/// Base address.
		/// </summary>
		private const string BaseAddress = "https://chatapi.viber.com/pa/";

		/// <summary>
		/// HTTP client.
		/// </summary>
		private readonly HttpClient _httpClient;

		/// <summary>
		/// Hash algorithm.
		/// </summary>
		private readonly HMACSHA256 _hashAlgorithm;

		/// <summary>
		/// JSON serializer settings.
		/// </summary>
		private readonly JsonSerializerSettings _jsonSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };

		/// <summary>
		/// Initializes a new instance of the <see cref="ViberBotClient"/> class.
		/// </summary>
		/// <param name="authenticationToken">Authentication token.</param>
		public ViberBotClient(string authenticationToken)
			: this(authenticationToken, null)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ViberBotClient"/> class.
		/// </summary>
		/// <param name="authenticationToken">Authentication token.</param>
		/// <param name="proxy">Proxy server.</param>
		public ViberBotClient(string authenticationToken, IWebProxy proxy)
		{
			_httpClient = proxy == null
				? new HttpClient()
				: new HttpClient(new HttpClientHandler { Proxy = proxy, UseProxy = true });
			_httpClient.BaseAddress = new Uri(BaseAddress);
			_httpClient.DefaultRequestHeaders.Add(XViberAuthTokenHeader, new[] { authenticationToken });

			_hashAlgorithm = new HMACSHA256(Encoding.UTF8.GetBytes(authenticationToken));
		}

		/// <inheritdoc />
		public async Task<ICollection<EventType>> SetWebhookAsync(string url, ICollection<EventType> eventTypes = null)
		{
			var result = await RequestApiAsync<SetWebhookResponse>(
				"set_webhook",
				new Dictionary<string, object>
				{
					{ "url", url },
					{ "event_types", eventTypes }
				});
			return result.EventTypes;
		}

		/// <inheritdoc />
		public async Task<IAccountInfo> GetAccountInfoAsync()
		{
			return await RequestApiAsync<GetAccountInfoResponse>("get_account_info");
		}

		/// <inheritdoc />
		public async Task<UserDetails> GetUserDetailsAsync(string id)
		{
			var response = await RequestApiAsync<GetUserDetailsResponse>(
				"get_user_details",
				new Dictionary<string, object> { { "id", id } });
			return response.User;
		}

		/// <inheritdoc />
		public Task<long> SendTextMessageAsync(TextMessage message) => SendMessageAsync(message);

		/// <inheritdoc />
		public Task<long> SendPictureMessageAsync(PictureMessage message) => SendMessageAsync(message);

		/// <inheritdoc />
		public Task<long> SendFileMessageAsync(FileMessage message) => SendMessageAsync(message);

		/// <inheritdoc />
		public Task<long> SendVideoMessageAsync(VideoMessage message) => SendMessageAsync(message);

		/// <inheritdoc />
		public Task<long> SendContactMessageAsync(ContactMessage message) => SendMessageAsync(message);

		/// <inheritdoc />
		public Task<long> SendLocationMessageAsync(LocationMessage message) => SendMessageAsync(message);

		/// <inheritdoc />
		public Task<long> SendUrlMessageAsync(UrlMessage message) => SendMessageAsync(message);

		/// <inheritdoc />
		public Task<long> SendStickerMessageAsync(StickerMessage message) => SendMessageAsync(message);

		/// <inheritdoc />
		public Task<long> SendKeyboardMessageAsync(KeyboardMessage message) => SendMessageAsync(message);

		/// <inheritdoc />
		public Task<long> SendBroadcastMessageAsync(BroadcastMessage message) => SendMessageAsync(message, true);

		/// <inheritdoc />
		public Task<long> SendCarouselMessageAsync(CarouselMessage message) => SendMessageAsync(message, true);

		/// <inheritdoc />
		public bool ValidateWebhookHash(string signatureHeader, string jsonMessage)
		{
			if (signatureHeader == null || jsonMessage == null)
			{
				return false;
			}

			try
			{
				var hash = _hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(jsonMessage));

#if NET461
				var signature = System.Runtime.Remoting.Metadata.W3cXsd2001.SoapHexBinary.Parse(signatureHeader).Value;
#else
				var signature = ParseHex(signatureHeader);
#endif

				return StructuralComparisons.StructuralEqualityComparer.Equals(hash, signature);
			}
			catch
			{
				return false;
			}
		}

		/// <summary>
		/// Sends message to Viber user.
		/// </summary>
		/// <param name="message">Instance of message</param>
		/// <param name="isBroadcast"><c>true</c> if broadcast message, otherwise - <c>false</c>.</param>
		/// <returns>Message token.</returns>
		private async Task<long> SendMessageAsync(MessageBase message, bool isBroadcast = false)
		{
			var result = await RequestApiAsync<SendMessageResponse>(isBroadcast ? "broadcast_message" : "send_message", message);
			return result.MessageToken;
		}

		/// <summary>
		/// Making API request.
		/// </summary>
		/// <param name="method">Method name.</param>
		/// <param name="data">Post data.</param>
		/// <typeparam name="T">Response type.</typeparam>
		/// <returns><typeparamref name="T"/> object.</returns>
		private async Task<T> RequestApiAsync<T>(string method, object data = null)
			where T : ApiResponseBase, new()
		{
			var requestJson = data == null
				? "{}"
				: JsonConvert.SerializeObject(data, _jsonSettings);
			var response = await _httpClient.PostAsync(method, new StringContent(requestJson));
			var responseJson = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<T>(responseJson);
			if (result.Status != ErrorCode.Ok)
			{
				throw new ViberRequestApiException(
					result.Status,
					result.StatusMessage,
					method,
					requestJson,
					responseJson);
			}

			return result;
		}

#if !NET461
		/// <summary>
		/// Parsing hex.
		/// </summary>
		/// <param name="hex">Hex string.</param>
		/// <returns>Array of bytes.</returns>
		private byte[] ParseHex(string hex)
		{
			var numberChars = hex.Length;
			var bytes = new byte[numberChars / 2];
			for (var i = 0; i < numberChars; i += 2)
			{
				bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
			}

			return bytes;
		}
#endif

		/// <summary>
		/// Releases the unmanaged resources used by the <see cref="ViberBotClient"/> and optionally disposes of the managed resources.
		/// </summary>
		/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to releases only unmanaged resources.</param>
		protected virtual void Dispose(bool disposing)
		{
			if (disposing)
			{
				_httpClient.Dispose();
				_hashAlgorithm.Dispose();
			}
		}

		/// <inheritdoc />
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}

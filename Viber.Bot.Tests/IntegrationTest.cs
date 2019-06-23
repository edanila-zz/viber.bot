using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Viber.Bot.Tests
{
	/// <summary>
	/// Viber bot integration test.
	/// </summary>
	[TestClass]
	public class IntegrationTest
	{
		/// <summary>
		/// Viber API.
		/// </summary>
		private IViberBotClient _viberBotClient;

		private string _authToken;
		private string _webhookUrl;
		private string _adminId;

		[TestInitialize]
		public void Init()
		{
			var config = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			_authToken = config["authToken"];
			_webhookUrl = config["webhookUrl"];
			_adminId = config["adminId"];

			_viberBotClient = new ViberBotClient(_authToken);
		}

		[TestMethod]
		public async Task GetAccountInfoAsyncTest()
		{
			var result = await _viberBotClient.GetAccountInfoAsync();
			return;
		}

		[TestMethod]
		[Priority(1)]
		public async Task SetWebhookAsync()
		{
			var result = await _viberBotClient.SetWebhookAsync(_webhookUrl);
			return;
		}

		//[TestMethod]
		public async Task GetUserDetailsAsyncTest()
		{
			var result = await _viberBotClient.GetUserDetailsAsync(_adminId);
			return;
		}

		[TestMethod]
		public async Task SendTextMessageAsyncTest()
		{
			var result = await _viberBotClient.SendTextMessageAsync(new TextMessage
			{
				Receiver = _adminId,
				Sender = new UserBase
				{
					Name = "Smbdy"
				},
				Text = "Hi!:)"
			});
			return;
		}

		[TestMethod]
		public async Task SendPictureMessageAsyncTest()
		{
			var result = await _viberBotClient.SendPictureMessageAsync(new PictureMessage
			{
				Receiver = _adminId,
				Sender = new UserBase
				{
					Name = "Smbdy"
				},
				Media = "https://upload.wikimedia.org/wikipedia/commons/5/57/Viber-logo.png"
			});
			return;
		}

		[TestMethod]
		public async Task SendContactMessageAsyncTest()
		{
			var result = await _viberBotClient.SendContactMessageAsync(new ContactMessage
			{
				Receiver = _adminId,
				Sender = new UserBase
				{
					Name = "Smbdy"
				},
				Contact = new Contact
				{
					Name = "Brad Pitt",
					TN = "+0123456789"
				}
			});
			return;
		}

		[TestMethod]
		public async Task SendFileMessageAsyncTest()
		{
			var result = await _viberBotClient.SendFileMessageAsync(new FileMessage
			{
				Receiver = _adminId,
				Sender = new UserBase
				{
					Name = "Smbdy"
				},
				Media = "http://www.sample-videos.com/audio/mp3/crowd-cheering.mp3",
				FileName = "audio.mp3",
				Size = 443926
			});
			return;
		}

		[TestMethod]
		public async Task SendLocationMessageAsyncTest()
		{
			var result = await _viberBotClient.SendLocationMessageAsync(new LocationMessage
			{
				Receiver = _adminId,
				Sender = new UserBase
				{
					Name = "Smbdy"
				},
				Location = new Location
				{
					Lon = 1,
					Lat = -2
				}
			});
			return;
		}

		[TestMethod]
		public async Task SendStickerMessageAsyncTest()
		{
			var result = await _viberBotClient.SendStickerMessageAsync(new StickerMessage
			{
				Receiver = _adminId,
				Sender = new UserBase
				{
					Name = "Smbdy"
				},
				StickerId = "40108"
			});
			return;
		}

		[TestMethod]
		public async Task SendVideoMessageAsyncTest()
		{
			var result = await _viberBotClient.SendVideoMessageAsync(new VideoMessage
			{
				Receiver = _adminId,
				Sender = new UserBase
				{
					Name = "Smbdy"
				},
				Media = "https://github.com/mediaelement/mediaelement-files/blob/master/big_buck_bunny.mp4?raw=true",
				Size = 5510872
			});
			return;
		}

		[TestMethod]
		public async Task SendUrlMessageAsyncTest()
		{
			var result = await _viberBotClient.SendUrlMessageAsync(new UrlMessage
			{
				Receiver = _adminId,
				Sender = new UserBase
				{
					Name = "Smbdy"
				},
				Media = "https://www.google.com"
			});
			return;
		}

		[TestMethod]
		public async Task SendKeyboardMessageAsyncTest()
		{
			var result = await _viberBotClient.SendKeyboardMessageAsync(new KeyboardMessage
			{
				Receiver = _adminId,
				Sender = new UserBase
				{
					Name = "Smbdy"
				},
				Text = "Test keyboard",
				Keyboard = new Keyboard
				{
					Buttons = new[]
					{
						new KeyboardButton
						{
							Text = "Button 1",
							ActionBody = "AB1"
						}
					}
				},
				TrackingData = "td"
			});
			return;
		}

		[TestMethod]
		public async Task SendBroadcastMessageAsyncTest()
		{
			var result = await _viberBotClient.SendBroadcastMessageAsync(new TextMessage
			{
				Sender = new UserBase
				{
					Name = "Smbdy"
				},
				Text = "Broadcast message!:)",
				BroadcastList = new List<string>
				{
					_adminId
                }
			});
			return;
		}
    }
}

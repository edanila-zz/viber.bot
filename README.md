# Viber.Bot
C# wrapper for the Viber REST API (Public Accounts / bots).

Webhook example using Owin:
```c#
	public class ViberWebhookMiddleware : OwinMiddleware
	{
		public ViberWebhookMiddleware() : base(null)
		{
		}

		public void Initialize(OwinMiddleware next)
		{
			Next = next;
		}

		public override async Task Invoke(IOwinContext context)
		{
			var isEndpointValid = true; // compare context.Request.Path and webhook url
			if (!isEndpointValid)
			{
				await Next.Invoke(context);
				return;
			}

			var body = new StreamReader(context.Request.Body).ReadToEnd();
			var isSignatureValid = viberBotClient.ValidateWebhookHash(
				context.Request.Headers[ViberBotClient.XViberContentSignatureHeader],
				body);
			if (!isSignatureValid)
			{
				throw new Exception("Invalid viber content signature");
			}

			var callbackData = JsonConvert.DeserializeObject<CallbackData>(body);
			// process callback
		}
	}
```

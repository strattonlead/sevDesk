using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using SevDesk.Api.V2.Security;

namespace SevDesk.Api.V2.Providers
{
	public class SevDeskClientProvider
	{
		private readonly IAccessTokenProvider _accessTokenProvider;
		private readonly AccessTokenProviderOptions _options;

		public SevDeskClientProvider(IAccessTokenProvider accessTokenProvider, AccessTokenProviderOptions options)
		{
			_accessTokenProvider = accessTokenProvider;
			_options = options;
		}

		public SevDeskClient Client
		{
			get
			{
				var authProvider = new BaseBearerTokenAuthenticationProvider(_accessTokenProvider);
				var adapter = new HttpClientRequestAdapter(authProvider);
				adapter.BaseUrl = $"https://{_options.BaseUrl}/".Replace("https://https://", "https://");
				return new SevDeskClient(adapter);
			}
		}
	}
}



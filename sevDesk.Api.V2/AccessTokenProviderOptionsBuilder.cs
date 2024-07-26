namespace SevDesk.Api.V2.Security
{
	public class AccessTokenProviderOptionsBuilder
	{
		internal AccessTokenProviderOptions Options { get; set; } = new AccessTokenProviderOptions();

		public AccessTokenProviderOptionsBuilder UseAllowedHosts(params string[] allowedHosts)
		{
			Options.AllowedHosts.AddRange(allowedHosts);
			return this;
		}

		public AccessTokenProviderOptionsBuilder UseApiKey(string apiKey)
		{
			Options.ApiKey = apiKey;
			return this;
		}

		public AccessTokenProviderOptionsBuilder UseBaseUrl(string baseUrl)
		{
			Options.BaseUrl = baseUrl;
			return this;
		}
	}
}

using Microsoft.Kiota.Abstractions.Authentication;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace SevDesk.Api.V2.Security
{
	public class AccessTokenProvider : IAccessTokenProvider
	{
		protected AccessTokenProviderOptions Options { get; set; }
		public AccessTokenProvider(AccessTokenProviderOptions options)
		{
			Options = options;
		}

		public AllowedHostsValidator AllowedHostsValidator => new AllowedHostsValidator(Options.AllowedHosts);

		public Task<string> GetAuthorizationTokenAsync(Uri uri, Dictionary<string, object> additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
		{
			return Task.FromResult(Options.ApiKey);
		}
	}
}

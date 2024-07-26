using Microsoft.Extensions.DependencyInjection;
using Microsoft.Kiota.Abstractions.Authentication;
using SevDesk.Api.V2.Providers;
using SevDesk.Api.V2.Security;
using System;
using System.Linq;

namespace SevDesk.Api.V2.DependencyInjection
{
	public static class DI
	{
		public static void AddSevDeskClient(this IServiceCollection services, Action<AccessTokenProviderOptionsBuilder> builderAction, ServiceLifetime serviceLifetime = ServiceLifetime.Transient)
		{
			var builder = new AccessTokenProviderOptionsBuilder();
			if (builderAction != null)
			{
				builderAction(builder);
			}

			if (string.IsNullOrWhiteSpace(builder.Options.BaseUrl))
			{
				builder.UseBaseUrl("https://my.sevdesk.de/api/v1");
			}

			if (!builder.Options.AllowedHosts.Any())
			{
				builder.UseAllowedHosts(new string[] { "my.sevdesk.de/api/v1" });
			}

			services.AddSingleton(builder.Options);

			switch (serviceLifetime)
			{
				case ServiceLifetime.Singleton:
					services.AddSingleton<IAccessTokenProvider, AccessTokenProvider>();
					services.AddSingleton<SevDeskClientProvider>();
					services.AddSingleton(x => x.GetRequiredService<SevDeskClientProvider>().Client);
					break;
				case ServiceLifetime.Scoped:
					services.AddScoped<IAccessTokenProvider, AccessTokenProvider>();
					services.AddScoped<SevDeskClientProvider>();
					services.AddScoped(x => x.GetRequiredService<SevDeskClientProvider>().Client);
					break;
				case ServiceLifetime.Transient:
				default:
					services.AddTransient<IAccessTokenProvider, AccessTokenProvider>();
					services.AddTransient<SevDeskClientProvider>();
					services.AddTransient(x => x.GetRequiredService<SevDeskClientProvider>().Client);
					break;
			}

		}
	}
}

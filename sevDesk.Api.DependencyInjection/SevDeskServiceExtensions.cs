using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace sevDesk.Api
{
	public static class SevDeskServiceExtensions
	{
		public static void AddSevDeskService(this IServiceCollection services, Action<SevDeskServiceOptionsBuilder> builder)
		{
			var optionsBuilder = new SevDeskServiceOptionsBuilder();
			builder?.Invoke(optionsBuilder);

			var options = optionsBuilder.Build();

			if (options.TokenProviderType != null)
			{
				services.TryAddScoped(options.TokenProviderType);
			}
			services.AddSingleton(options);
			services.AddScoped<ISevDeskClient, SevDeskClient>();
			services.AddScoped<ISevDeskService, SevDeskService>();
		}
	}
}

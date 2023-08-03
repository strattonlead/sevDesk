using Microsoft.Extensions.DependencyInjection;

namespace sevDesk.Api
{
    public static class SevDeskServiceExtensions
    {
        public static void AddSevDeskService(this IServiceCollection services, Action<SevDeskServiceOptionsBuilder> builder)
        {
            var optionsBuilder = new SevDeskServiceOptionsBuilder();
            builder?.Invoke(optionsBuilder);

            var options = optionsBuilder.Build();
            services.AddSingleton(options);
            services.AddScoped<ISevDeskClient, SevDeskClient>();
            services.AddScoped<ISevDeskService, SevDeskService>();
        }
    }
}

using Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace SortieApp.Application
{
    public static class ApplicationService
    {
        public static IServiceCollection ConfigureApplicationService(this IServiceCollection services)
        {
            services.AddSingleton<SortieService>();
            return services;
        }
    }
}
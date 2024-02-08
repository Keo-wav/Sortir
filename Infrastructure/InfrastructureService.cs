using Infrastructure.Contexts;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SortieApp.Infrastructure
{
    public static class InfrastructureService
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddSingleton<SortieRepository>();
            services.AddDbContext<SortieContext>(options=>options.UseSqlServer("Data Source=48SE46-HM5HHZ3;Initial Catalog=SORTIR;User ID=SA;Password=***********;Trust Server Certificate=True"));
            return services;
        }

    }
}

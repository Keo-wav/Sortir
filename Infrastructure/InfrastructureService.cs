using Infrastructure.Contexts;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SortieApp.Infrastructure
{
    public static class InfrastructureService
    {
        public static IServiceCollection ConfigureInfrastructureService(this IServiceCollection services)
        {
            services.AddScoped<IInscriptionRepository, InscriptionRepository>();
            services.AddScoped<ILieuRepository, LieuRepository>();
            services.AddScoped<IParticipantRepository, ParticipantRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IEtatRepository, EtatRepository>();
            services.AddScoped<ISortieRepository, SortieRepository>();
            services.AddDbContext<EtatContext>(options=>options.UseSqlServer("Data Source=48SE46-HM5HHZ3;Initial Catalog=SORTIR;User ID=SA;Password=***********;Trust Server Certificate=True"));
            services.AddDbContext<InscriptionContext>(options => options.UseSqlServer("Data Source=48SE46-HM5HHZ3;Initial Catalog=SORTIR;User ID=SA;Password=***********;Trust Server Certificate=True"));
            services.AddDbContext<LieuContext>(options => options.UseSqlServer("Data Source=48SE46-HM5HHZ3;Initial Catalog=SORTIR;User ID=SA;Password=***********;Trust Server Certificate=True"));
            services.AddDbContext<ParticipantContext>(options => options.UseSqlServer("Data Source=48SE46-HM5HHZ3;Initial Catalog=SORTIR;User ID=SA;Password=***********;Trust Server Certificate=True"));
            services.AddDbContext<RoleContext>(options => options.UseSqlServer("Data Source=48SE46-HM5HHZ3;Initial Catalog=SORTIR;User ID=SA;Password=***********;Trust Server Certificate=True"));
            services.AddDbContext<SortieContext>(options => options.UseSqlServer("Data Source=48SE46-HM5HHZ3;Initial Catalog=SORTIR;User ID=SA;Password=***********;Trust Server Certificate=True"));
            return services;
        }

    }
}

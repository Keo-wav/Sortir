﻿using Application.Services;
using Infrastructure.Contexts;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SortieApp.Application
{
    public static class ApplicationService
    {
        public static IServiceCollection ConfigureApplicationService(this IServiceCollection services)
        {
            services.AddScoped<ISortieService, SortieService>();
            return services;
        }

    }
}
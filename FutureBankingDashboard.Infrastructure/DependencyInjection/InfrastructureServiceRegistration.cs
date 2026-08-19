using FutureBankingDashboard.Infrastructure.Repositories;
using FutureBankingDashboard.Library.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace FutureBankingDashboard.Infrastructure.DependencyInjection
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            // Repository bindings
            services.AddScoped<IEconomyRepository, EconomyRepository>();
            services.AddScoped<ISustainabilityRepository, SustainabilityRepository>();
            services.AddScoped<IFundingRepository, FundingRepository>();
            services.AddScoped<IRecommendationRepository, RecommendationRepository>();

            return services;
        }
    }
}

using Microsoft.AspNetCore.Mvc.Infrastructure;
using MoustafaMarket.Api.Common.Errors;
using MoustafaMarket.Api.Common.Mapping;

namespace MoustafaMarket.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers();
        services.AddMapping();
        services.AddSingleton<ProblemDetailsFactory, MarketProblemDetailsFactory>();    
        return services;
    }
}

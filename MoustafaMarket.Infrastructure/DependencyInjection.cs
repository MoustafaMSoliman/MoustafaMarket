using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoustafaMarket.Application.Persistence;
using MoustafaMarket.Infrastructure.Persistence;

namespace MoustafaMarket.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<MarketDbContext>( options => options.UseSqlServer());
      
        return services;
    }
}

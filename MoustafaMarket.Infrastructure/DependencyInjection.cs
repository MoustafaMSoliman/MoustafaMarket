using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MoustafaMarket.Application.Persistence;
using MoustafaMarket.Domain.Common.Persistence;
using MoustafaMarket.Infrastructure.Persistence;

namespace MoustafaMarket.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<MarketDbContext>( options => options.UseSqlServer());
        /*
         *  You should not register IGenericRepository<TEntity> and GenericRepository<TEntity> directly in your dependency injection (DI) container. 
         *  Instead, you should register the Unit of Work (IUnitOfWork, UnitOfWork) because it provides access to repositories dynamically.

             Why?
                Loose Coupling: 
                   The Unit of Work creates repositories dynamically when needed, so you don't have to register each repository manually.
                Better Lifecycle Management:  
                   The Unit of Work ensures that repositories share the same DbContext instance, preventing issues like multiple DbContext instances in a single request.
                More Scalable: 
                   If you register IGenericRepository<TEntity>, you'd have to manually register each entity type (IGenericRepository<Product>, IGenericRepository<Order>, etc.), which isn't practical.
         * */
        services.AddScoped<IUnitOFWork, UnitOFWork>();
        return services;
    }
}

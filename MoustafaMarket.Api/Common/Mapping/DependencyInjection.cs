using Mapster;
using MapsterMapper;
using System.Reflection;

namespace MoustafaMarket.Api.Common.Mapping;

public static class DependencyInjection
{
    public static IServiceCollection AddMapping(this IServiceCollection services)
    {
        // detect the config
        var config = TypeAdapterConfig.GlobalSettings;
        // scan for configurations
        config.Scan(Assembly.GetExecutingAssembly());
        // register the config
        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();
        return services;
    }
}

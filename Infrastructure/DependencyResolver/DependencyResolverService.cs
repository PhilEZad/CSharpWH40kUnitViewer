using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyResolver;

public static class DependencyResolverService
{
    public static void RegisterInfrastructureLayer(IServiceCollection service)
    {
        service.AddScoped<IUnitRepository, UnitRepository>();
        service.AddScoped<IFactionRepository, FactionRepository>();
        service.AddScoped<IStratagemRepository, StratagemRepository>();
    }
}
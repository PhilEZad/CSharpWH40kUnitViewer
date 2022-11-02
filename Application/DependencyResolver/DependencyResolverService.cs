using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Application.DependencyResolver;

public static class DependencyResolverService
{
    public static void RegisterApplicationLayer(IServiceCollection services)
    {
        services.AddScoped<IUnitService, UnitService>();
        services.AddScoped<IFactionService, FactionService>();
        services.AddScoped<IStratagemService, StratagemService>();
    }
}
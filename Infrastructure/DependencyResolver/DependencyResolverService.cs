using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.DependencyResolver;

public static class DependencyResolverService
{
    public static void RegisterApplicationLayer(IServiceCollection service)
    {
        service.AddScoped<IUnitRepository, DatabaseRepository>();
    }
}
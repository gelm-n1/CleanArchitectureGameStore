using CleanArchitectureGameStore.Application.Interfaces;
using CleanArchitectureGameStore.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureGameStore.Infrastructure.Extensions;

public static class IServiceCollectionExtensions
{
    public static void AddInfrastructureLayer(this IServiceCollection services)
    {
        services.AddServices();
    }

    private static void AddServices(this IServiceCollection services)
    {
        services.AddTransient<IEmailService, EmailService>();
    }
}
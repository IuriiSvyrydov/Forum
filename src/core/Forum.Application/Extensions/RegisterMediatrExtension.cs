using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Forum.Application.Extensions;

public static class RegisterMediatrExtension
{
    public static IServiceCollection RegisterMediatr(this IServiceCollection services)
    {
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        });
        return services;
    }
    
}
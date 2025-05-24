using System.Reflection;
using Forum.Application.Mapping;
using Microsoft.Extensions.DependencyInjection;


namespace Forum.Application.Extensions;

public static class RegisterAutoMapperExtension
{
    public static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddAutoMapper(typeof(CategoryProfile));
       // services.AddAutoMapper(typeof(PostProfile));
        services.AddAutoMapper(typeof(UserProfile));
        services.AddAutoMapper(typeof(CommentProfile));
        return services;
    }
    
}
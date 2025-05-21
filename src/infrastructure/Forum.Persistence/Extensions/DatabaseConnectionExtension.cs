
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Forum.Persistence.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace Forum.Persistence.Extensions
{
    public static class DatabaseConnectionExtension
    {
        public static IServiceCollection RegisterDatabaseConnection(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options=>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            return services;
        }
    }
}
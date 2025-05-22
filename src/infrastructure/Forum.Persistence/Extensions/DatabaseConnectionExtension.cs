

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
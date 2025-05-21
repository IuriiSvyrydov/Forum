using Core.Domain.Common;
using Core.Domain.Common.Repositories;
using Core.Domain.Entities.Categories;
using Forum.Persistence.Repositories;
using Forum.Persistence.Repositories.Categories;
using Forum.Persistence.Repositories.GenericRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Forum.Persistence.Extensions;

public static class RegisterRepositoriesExtensions
{
    public static void RegisterRepositories(this IServiceCollection services)
    {
        #region Generic Repositories

        services.AddScoped(typeof(IReadRepository<,>), typeof(ReadRepository<,>));
        services.AddScoped(typeof(IWriteRepository<>), typeof(IWriteRepository<>));

        #endregion
        #region Unit of Work
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        #endregion
        #region Category Repositories
        services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
        #endregion
    }
    
}
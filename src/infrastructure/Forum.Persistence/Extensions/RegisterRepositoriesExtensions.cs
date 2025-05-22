


using Core.Domain.Entitites.Categories;
using Core.Domain.Entitites.SubComments;
using Core.Domain.Entitites.Users;
using Forum.Persistence.Repositories.PostsStatus;
using Forum.Persistence.Repositories.SubComments;
using Forum.Persistence.Repositories.Users;

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
        services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
        #endregion

        #region Comment Repositories

        services.AddScoped<ICommentReadRepository, CommentReadRepository>();
        services.AddScoped<ICommentWriteRepository, CommentWriteRepository>();

        #endregion

        #region Post Repositories

        services.AddScoped<IPostReadRepository, PostReadRepository>();
        services.AddScoped<IPostWriteRepository, PostWriteRepository>();

        #endregion
        #region PostStatus Repositories

        services.AddScoped<IPostStatusReadRepository, PostStatusReadRepository>();
        services.AddScoped<IPostStatusWriteRepository, PostStatusWriteRepository>();

        #endregion
        #region SubComment Repositories

        services.AddScoped<ISubCommentReadRepository, SubCommentReadRepository>();
        services.AddScoped<ISubCommentWriteRepository, SubCommentWriteRepository>();

        #endregion
        #region User Repositories

        services.AddScoped<IUserReadRepository, UserReadRepository>();
        services.AddScoped<IUserWriteRepository, UserWriteRepository>();

        #endregion
    }
    
}
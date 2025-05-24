using Core.Domain.Entities.Posts;
using Core.Domain.Entitites.Posts.ValueObjects;
using Forum.Persistence.EntityFramework;
using Forum.Persistence.Repositories.GenericRepositories;

namespace Forum.Persistence.Repositories.Posts;

public sealed class PostReadRepository:ReadRepository<Post,PostId>,IPostReadRepository
{
    public PostReadRepository(AppDbContext context) : base(context)
    {
    }
}
using Core.Domain.Entities.PostsStatus;
using Core.Domain.PostsStatus.ValueObjects;

namespace Forum.Persistence.Repositories.PostsStatus;

public sealed class PostStatusReadRepository: ReadRepository<PostStatus,PostStatusId>,IPostStatusReadRepository
{
    public PostStatusReadRepository(AppDbContext context) : base(context)
    {
    }
}
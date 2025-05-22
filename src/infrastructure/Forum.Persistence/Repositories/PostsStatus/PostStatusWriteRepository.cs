

namespace Forum.Persistence.Repositories.PostsStatus;

public sealed class PostStatusWriteRepository: WriteRepository<PostStatus>,IPostStatusWriteRepository
{
    public PostStatusWriteRepository(AppDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }
}
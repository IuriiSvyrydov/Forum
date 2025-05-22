using Core.Domain.Common;
using Core.Domain.Entities.Posts;
using Core.Domain.Entitites.Posts;
using Forum.Persistence.EntityFramework;
using Forum.Persistence.Repositories.GenericRepositories;

namespace Forum.Persistence.Repositories.Posts;

public sealed class PostWriteRepository : WriteRepository<Post>, IPostWriteRepository
{
    public PostWriteRepository(AppDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }
}
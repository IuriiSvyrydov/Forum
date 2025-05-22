using Core.Domain.Common;
using Core.Domain.Entities.Comments;
using Core.Domain.Entitites.Comments;
using Forum.Persistence.EntityFramework;
using Forum.Persistence.Repositories.GenericRepositories;

namespace Forum.Persistence.Repositories.Comments;

public sealed class CommentWriteRepository: WriteRepository<Comment>,ICommentWriteRepository
{
    public CommentWriteRepository(AppDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }

}
using Core.Domain.Entities.Comments.ValueObjects;
using Core.Domain.Entitites.Comments;

namespace Forum.Persistence.Repositories.Comments;

public sealed class CommentReadRepository : ReadRepository<Comment,CommentId>,ICommentReadRepository
{
    public CommentReadRepository(AppDbContext context) : base(context)
    {
    }
}
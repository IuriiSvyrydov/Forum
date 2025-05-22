using Core.Domain.Common.Repositories;
using Core.Domain.Entities.Comments.ValueObjects;
using Core.Domain.Entitites.Comments;

namespace Core.Domain.Entities.Comments;

public interface ICommentReadRepository: IReadRepository<Comment,CommentId>
{
    
}
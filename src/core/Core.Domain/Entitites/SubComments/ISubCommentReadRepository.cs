using Core.Domain.Common.Repositories;
using Core.Domain.Entities.SubComments;
using Core.Domain.Entities.SubComments.ValueObjects;

namespace Core.Domain.Entitites.SubComments;

public interface ISubCommentReadRepository : IReadRepository<SubComment,SubCommentId>
{
    
}
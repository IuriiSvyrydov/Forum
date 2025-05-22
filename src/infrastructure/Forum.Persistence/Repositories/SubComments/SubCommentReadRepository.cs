using Core.Domain.Entities.SubComments;
using Core.Domain.Entities.SubComments.ValueObjects;
using Core.Domain.Entitites.SubComments;

namespace Forum.Persistence.Repositories.SubComments;

public sealed  class SubCommentReadRepository: ReadRepository<SubComment,SubCommentId>,ISubCommentReadRepository
{
    public SubCommentReadRepository(AppDbContext context) : base(context)
    {
    }
}
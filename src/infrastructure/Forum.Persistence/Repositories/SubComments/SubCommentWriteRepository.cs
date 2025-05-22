using Core.Domain.Entities.SubComments;
using Core.Domain.Entitites.SubComments;

namespace Forum.Persistence.Repositories.SubComments;

public sealed  class SubCommentWriteRepository: WriteRepository<SubComment>,ISubCommentWriteRepository
{
    public SubCommentWriteRepository(AppDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }
}
using Core.Domain.Entities.Users;
using Core.Domain.Entitites.Users;

namespace Forum.Persistence.Repositories.Users;

public sealed class UserWriteRepository: WriteRepository<User>,IUserWriteRepository
{
    public UserWriteRepository(AppDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }
}
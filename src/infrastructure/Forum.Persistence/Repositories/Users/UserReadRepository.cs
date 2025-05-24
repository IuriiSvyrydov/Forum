using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.Users;
using Core.Domain.Entitites.Users.ValueObjects;

namespace Forum.Persistence.Repositories.Users;

public sealed class UserReadRepository: ReadRepository<User,UserId>,IUserReadRepository
{
    public UserReadRepository(AppDbContext context) : base(context)
    {
    }
}
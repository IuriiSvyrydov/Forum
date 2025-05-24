using Core.Domain.Common.Repositories;
using Core.Domain.Entities.Users;
using Core.Domain.Entities.Users.ValueObjects;
using Core.Domain.Entitites.Users.ValueObjects;

namespace Core.Domain.Entitites.Users;

public interface IUserReadRepository : IReadRepository<User,UserId>
{
    
}
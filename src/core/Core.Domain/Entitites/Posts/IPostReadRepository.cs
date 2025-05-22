using Core.Domain.Common.Repositories;
using Core.Domain.Entities.Posts;
using Core.Domain.Posts.ValueObjects;

namespace Core.Domain.Entitites.Posts;

public interface IPostReadRepository : IReadRepository<Post,PostId>
{
    
}
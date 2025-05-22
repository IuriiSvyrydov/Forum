using Core.Domain.Common.Repositories;
using Core.Domain.Entities.PostsStatus;
using Core.Domain.PostsStatus.ValueObjects;

namespace Core.Domain.Entitites.PostsStatus;

public interface IPostStatusReadRepository: IReadRepository<PostStatus,PostStatusId>
{
    
}
using Core.Domain.Entities.Categories.ValueObjects;
using Core.Domain.PostsStatus.ValueObjects;
using Name = Core.Domain.Entities.PostsStatus.ValueObjects.Name;

namespace Core.Domain.Entities.PostsStatus;

using Name = ValueObjects.Name;

public sealed class PostStatus
    {
        public PostStatusId PostStatusId { get; set; }
        public Name Name { get; set; }
    }

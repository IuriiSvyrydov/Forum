using Core.Domain.Entities.Posts.ValueObjects;
using Core.Domain.PostsStatus.ValueObjects;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forum.Persistence.Converters;

    public class PostStatusIdConverter : ValueConverter<PostStatusId,Guid>
    {
        public PostStatusIdConverter() : base(v => v.Value,
         v => PostStatusId.Create(v).Value!)
        {
        }
    }
    public class PostStatusIdComparer : ValueComparer<PostStatusId>
    {
        public PostStatusIdComparer():base(
            (x,y)=>x!.Value==y!.Value,
            x=>x.Value.GetHashCode())
        {
      
        }

    }

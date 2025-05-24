using Core.Domain.Entities.Posts.ValueObjects;
using Core.Domain.Entitites.Posts.ValueObjects;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forum.Persistence.Converters
{
    public sealed class PostIdConverter : ValueConverter<PostId,Guid>
    {
        public PostIdConverter() : base(v => v.Value, v => PostId.Create(v).Value!)
        {
        }
    }
      public class PostIdComparer : ValueComparer<PostId>
    {
        public PostIdComparer():base(
            (x,y)=>x!.Value==y!.Value,
            x=>x.Value.GetHashCode())
        {
      
        }

    }
}
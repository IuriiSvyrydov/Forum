using Core.Domain.Entities.Comments.ValueObjects;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forum.Persistence.Converters
{
    public sealed class CommentIdConverter : ValueConverter<CommentId, Guid>
    {
        public CommentIdConverter() : base(
            id => id.Value,
            value => new CommentId(value))
        {
        }
    }
    public class CommentIdComparer : ValueComparer<CommentId>
    {
        public CommentIdComparer():base(
            (x,y)=>x!.Value==y!.Value,
            x=>x.Value.GetHashCode())
        {
      
        }

    }
}
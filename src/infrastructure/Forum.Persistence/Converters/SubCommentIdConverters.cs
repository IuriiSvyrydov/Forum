
using Core.Domain.Entities.SubComments.ValueObjects;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forum.Persistence.Converters;

public class SubCommentIdConverters : ValueConverter<SubCommentId,Guid>
{
    public SubCommentIdConverters() : base(v => v.Value,
        v => SubCommentId.Create(v).Value!)
    {
    }
}
public class SubCommentIdComparer : ValueComparer<SubCommentId>
{
    public SubCommentIdComparer():base(
        (x,y)=>x!.Value==y!.Value,
        x=>x.Value.GetHashCode())
    {
      
    }

}
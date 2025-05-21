using Core.Domain.Entities.Categories.ValueObjects;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forum.Persistence.Converters;

    public class CategoryIdConverters : ValueConverter<CategoryId,Guid>
    {
        public CategoryIdConverters() : base(v => v.Value,
         v => CategoryId.Create(v).Value!)
        {
        }
    }
    public class CategoryIdComparer : ValueComparer<CategoryId>
    {
        public CategoryIdComparer():base(
            (x,y)=>x!.Value==y!.Value,
            x=>x.Value.GetHashCode())
        {
      
        }

    }



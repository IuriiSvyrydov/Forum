using Core.Domain.Common.Results;
using Core.Domain.Entities.Users.ValueObjects;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Forum.Persistence.Converters;

    public sealed class UserIdConverter : ValueConverter<UserId,Guid>
    {
        public UserIdConverter() : base(v => v.Value,
            v => UserId.Create(v).Value!)
        {
        }
    }

    public sealed class UserIdComparer : ValueComparer<UserId>
    {
        public UserIdComparer() : base(
            (x, y) => x!.Value == y!.Value,
            x => x.Value.GetHashCode())
        {

        }
    }
 

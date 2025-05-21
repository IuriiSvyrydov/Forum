using Core.Domain.Common;

namespace Core.Domain.Entities.Users.ValueObjects
{
    public class UserId : ValueObject<Guid>
    {
        public UserId(Guid value) : base(value)
        {
        }
    }
}
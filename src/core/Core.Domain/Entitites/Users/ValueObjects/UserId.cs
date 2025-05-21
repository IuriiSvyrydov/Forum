using Core.Domain.Common;
using Core.Domain.Common.Results;
using Core.Domain.Entities.SubComments.ValueObjects;

namespace Core.Domain.Entities.Users.ValueObjects
{
    public class UserId : ValueObject<Guid>
    {
        public UserId(Guid value) : base(value)
        {
        }
        public static ValidationResult<UserId> Create(Guid id)
        {
            var error = new List<string>();
            if (id == Guid.Empty)
                error.Add(" ID can not be empty");
            return error.Count == 0 ? ValidationResult<UserId>.Success(new UserId(id))
                : ValidationResult<UserId>.Failure(error);
        }
        public static UserId NewId()
        {
            return Create(Guid.NewGuid()).Value!;
        }
        
    }
}

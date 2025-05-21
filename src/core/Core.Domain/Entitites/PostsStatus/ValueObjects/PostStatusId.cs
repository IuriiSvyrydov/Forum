using Core.Domain.Common;
using Core.Domain.Common.Results;

namespace Core.Domain.PostsStatus.ValueObjects
{
    public class PostStatusId : ValueObject<Guid>
    {
        public PostStatusId()
        {
        }

        public PostStatusId(Guid value) : base(value)
        {
        }
        public static ValidationResult<PostStatusId> Create(Guid id)
        {
            var error = new List<string>();
            if (id == Guid.Empty)
                error.Add(" ID can not be empty");
            return error.Count == 0 ? ValidationResult<PostStatusId>.Success(new PostStatusId(id))
            : ValidationResult<PostStatusId>.Failure(error);
        }
        public static PostStatusId NewId()
        {
            return Create(Guid.NewGuid()).Value!;
        }

    }
}
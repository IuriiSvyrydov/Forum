
using Core.Domain.Common;
using Core.Domain.Common.Results;
using Core.Domain.Entities.Categories.ValueObjects;

namespace Core.Domain.Entities.Comments.ValueObjects;

public class CommentId : ValueObject<Guid>
{
    public CommentId()
    {
    }

    public CommentId(Guid value) : base(value)
    {
    }
    public static ValidationResult<CommentId> Create(Guid id)
    {
        var error = new List<string>();
        if (id == Guid.Empty)
            error.Add(" ID can not be empty");
        return error.Count == 0 ? ValidationResult<CommentId>.Success(new CommentId(id))
        : ValidationResult<CommentId>.Failure(error);
    }
    public static CommentId NewId()
    {
        return Create(Guid.NewGuid()).Value!;
    }
}

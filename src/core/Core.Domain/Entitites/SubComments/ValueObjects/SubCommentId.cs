using System.Threading.Tasks;
using Core.Domain.Common;
using Core.Domain.Common.Results;

namespace Core.Domain.Entities.SubComments.ValueObjects;

    public class SubCommentId : ValueObject<Guid>
    {
        public SubCommentId()
        {
        }

        public SubCommentId(Guid value) : base(value)
        {
    }
    public static ValidationResult<SubCommentId> Create(Guid id)
    {
        var error = new List<string>();
        if (id == Guid.Empty)
            error.Add(" ID can not be empty");
        return error.Count == 0 ? ValidationResult<SubCommentId>.Success(new SubCommentId(id))
        : ValidationResult<SubCommentId>.Failure(error);
    }
    public static SubCommentId NewId()
    {
        return Create(Guid.NewGuid()).Value!;
    }
        
    }

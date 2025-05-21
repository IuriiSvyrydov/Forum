
using Core.Domain.Common;
using Core.Domain.Common.Results;

namespace Core.Domain.Posts.ValueObjects;

public class PostId : ValueObject<Guid>
{
    #region Properties
    private List<IDomainEvents> _domainEvents;
    public IReadOnlyList<IDomainEvents> DomainEvents=>_domainEvents.AsReadOnly();
    #endregion
    #region Methods
    public void AddDomainEvent(IDomainEvents domainEvent)
    {
        _domainEvents = _domainEvents ?? new List<IDomainEvents>();
        _domainEvents.Add(domainEvent);
    }
    public void RemoveDomainEvent(IDomainEvents domainEvent)
    {
        _domainEvents?.Remove(domainEvent);
    }
    public void ClearDomainEvents()
    {
        _domainEvents?.Clear();
    }

    #endregion
    #region Constructors
    public PostId()
    {
    }

    public PostId(Guid value) : base(value)
    {
    }
    public static ValidationResult<PostId> Create(Guid id)
    {
        var error = new List<string>();
        if (id == Guid.Empty)
            error.Add(" ID can not be empty");
        return error.Count == 0 ? ValidationResult<PostId>.Success(new PostId(id)) 
            : ValidationResult<PostId>.Failure(error);      
    }
    public static PostId NewId()
    {
        return Create(Guid.NewGuid()).Value!;
    }
    #endregion
}

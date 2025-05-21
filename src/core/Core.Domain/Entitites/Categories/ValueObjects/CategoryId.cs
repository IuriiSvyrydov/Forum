using Core.Domain.Common;
using Core.Domain.Common.Results;
using MediatR;

namespace Core.Domain.Entities.Categories.ValueObjects;

public class CategoryId : ValueObject<Guid>,INotification
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
    public CategoryId()
    {
    }

    public CategoryId(Guid value) : base(value)
    {
    }
    public static ValidationResult<CategoryId> Create(Guid id)
    {
        var error = new List<string>();
        if (id == Guid.Empty)
            error.Add(" ID can not be empty");
            return error.Count == 0 ? ValidationResult<CategoryId>.Success(new CategoryId(id)) 
            : ValidationResult<CategoryId>.Failure(error);      
    }
    public static CategoryId NewId()
    {
        return Create(Guid.NewGuid()).Value!;
    }
    #endregion
}

using Core.Domain.Common.Repositories;
using Core.Domain.Entities.Categories.ValueObjects;

namespace Core.Domain.Entities.Categories
{
    public interface ICategoryReadRepository : IReadRepository<Category,CategoryId>
    {
        
        
    }
}
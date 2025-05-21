
using Core.Domain.Entities.Categories;
using Core.Domain.Entities.Categories.ValueObjects;
using Forum.Persistence.EntityFramework;
using Forum.Persistence.Repositories.GenericRepositories;

namespace Forum.Persistence.Repositories.Categories
{
    public sealed class CategoryReadRepository:ReadRepository<Category,CategoryId>,ICategoryReadRepository
    {
        public CategoryReadRepository(AppDbContext context) : base(context)
        {
        }
    }
}
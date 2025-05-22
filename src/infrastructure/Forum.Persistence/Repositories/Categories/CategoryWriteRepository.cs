using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain.Common;
using Core.Domain.Entities;
using Core.Domain.Entities.Categories;
using Core.Domain.Entitites.Categories;
using Forum.Persistence.EntityFramework;
using Forum.Persistence.Repositories.GenericRepositories;

namespace Forum.Persistence.Repositories.Categories
{
    public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
    {
        public CategoryWriteRepository(AppDbContext context, IUnitOfWork unitOfWork) : base(context, unitOfWork)
        {
        }
    }
}
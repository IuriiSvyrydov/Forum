using Core.Domain.Common.Repositories;
using Core.Domain.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Domain.Entitites.Categories
{
    public interface ICategoryWriteRepository : IWriteRepository<Category>
    {
        
    }
}
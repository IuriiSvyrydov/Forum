
using Core.Domain.Common.Repositories;

using Forum.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Forum.Persistence.Repositories.GenericRepositories
{
    public class ReadRepository<T,TId> :IReadRepository<T,TId> where T : class
    {
        private readonly AppDbContext _context;
        public ReadRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Set<T>().ToListAsync(cancellationToken);
        }

        public async Task<T?> GetByIdAsync(TId id, CancellationToken cancellationToken = default)
        {
            return await _context.Set<T>().FindAsync(id, cancellationToken);
        }
    }
}

using System.Threading;
using System.Threading.Tasks;
using Core.Domain.Common;
using Forum.Persistence.EntityFramework;

namespace Forum.Persistence.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        
           => await _context.SaveChangesAsync(cancellationToken);
        
    }
}
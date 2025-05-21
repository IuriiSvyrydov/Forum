using Core.Domain.Common;
using Core.Domain.Common.Repositories;
using Forum.Persistence.EntityFramework;

namespace Forum.Persistence.Repositories.GenericRepositories;

public class WriteRepository<T> :IWriteRepository<T> where T : class
{
    private readonly AppDbContext _context;
    private readonly IUnitOfWork _unitOfWork;
    public WriteRepository(AppDbContext context,IUnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
    }
    public async Task AddAsync(T entity, CancellationToken cancellationToken = default)
    {
        _context.Set<T>().Add(entity);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task UpdateAsync(T entity, CancellationToken cancellationToken = default)
    {
        _context.Set<T>().Update(entity);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteAsync(T entity, CancellationToken cancellationToken = default)
    {
        _context.Set<T>().Remove(entity);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
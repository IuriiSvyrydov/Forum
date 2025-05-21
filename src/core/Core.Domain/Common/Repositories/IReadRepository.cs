

namespace Core.Domain.Common.Repositories;

public interface IReadRepository<T,TId> where T : class
{
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<T?> GetByIdAsync(TId id, CancellationToken cancellationToken = default);
}

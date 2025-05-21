﻿
namespace Core.Domain.Common.Repositories
{
    public interface IWriteRepository<T> where T : class
    {
        Task AddAsync(T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, CancellationToken cancellationToken = default);
        Task DeleteAsync(T entity, CancellationToken cancellationToken = default);
    }
}

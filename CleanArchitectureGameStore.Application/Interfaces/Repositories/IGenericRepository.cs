using CleanArchitectureGameStore.Domain.Common.Interfaces;

namespace CleanArchitectureGameStore.Application.Interfaces.Repositories;

public interface IGenericRepository<T> where T : class, IEntity
{
    IQueryable<T> Entities { get; }

    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(int id);
    Task<T> AddAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(T entity);
}
using System.Collections;
using CleanArchitectureGameStore.Application.Interfaces.Repositories;
using CleanArchitectureGameStore.Domain.Common;
using CleanArchitectureGameStore.Persistence.Context;

namespace CleanArchitectureGameStore.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _dbContext;
    private Hashtable _repositories;
    private bool disposed;

    public UnitOfWork(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public IGenericRepository<T> Repository<T>() where T : BaseAuditableEntity
    {
        if (_repositories == null) _repositories = new Hashtable();

        var type = typeof(T).Name;

        if (!_repositories.ContainsKey(type))
        {
            var repositoryType = typeof(GenericRepository<>);

            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _dbContext);

            _repositories.Add(type, repositoryInstance);
        }

        return (IGenericRepository<T>)_repositories[type];
    }

    public async Task<int> Save(CancellationToken cancellationToken)
    {
        return await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public Task Rollback()
    {
         _dbContext.ChangeTracker.Entries().ToList().ForEach(x => x.Reload());
         return Task.CompletedTask;
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) if (disposing) _dbContext.Dispose();
        disposed = true;
    }
}
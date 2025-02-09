using MoustafaMarket.Domain.Common.Persistence;
using System.Security.Claims;

namespace MoustafaMarket.Infrastructure.Persistence;

public class UnitOFWork : IUnitOFWork
{
   /*
    * Should You Define All Repositories in the UnitOfWork Class?

       It depends on how you're structuring your Unit of Work (UoW) pattern. Generally, you have two common approaches:

         1- Defining all repositories inside the UnitOfWork class (Tightly Coupled).
         2- Keeping repositories independent but managed by UnitOfWork(Loosely Coupled - Recommended).

   */
    private readonly MarketDbContext _marketDbContext;
    private readonly Dictionary<Type, object> _repositories = new();

    public UnitOFWork(MarketDbContext marketDbContext)
    {
        _marketDbContext = marketDbContext;
    }
   
    public void Dispose()
    {
        _marketDbContext.Dispose();
    }

    public IRepository<TEntity> Repository<TEntity>() where TEntity : class
    {
        if (!_repositories.ContainsKey(typeof(TEntity)))
        {
            _repositories[typeof(TEntity)] = new Repository<TEntity>(_marketDbContext);
        }
        return (IRepository<TEntity>)_repositories[typeof(TEntity)];

    }

    public async Task<int> SaveChangesAsync()
    {
       return await _marketDbContext.SaveChangesAsync();
    }
}

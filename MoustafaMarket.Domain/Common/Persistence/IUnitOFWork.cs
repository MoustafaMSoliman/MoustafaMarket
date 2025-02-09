namespace MoustafaMarket.Domain.Common.Persistence;

public interface IUnitOFWork : IDisposable
{
    IRepository<TEntity> Repository<TEntity>() where TEntity : class;
    Task<int> SaveChangesAsync();
}

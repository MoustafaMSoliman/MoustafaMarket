using Microsoft.EntityFrameworkCore;
using MoustafaMarket.Domain.Common.Persistence;

namespace MoustafaMarket.Infrastructure.Persistence;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly MarketDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(MarketDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T?> GetByIdAsync(object id)
    {
        return await _dbSet.FindAsync(id);
    }

   

    public void Update(T entity)
    {
       _dbSet.Update(entity);
    }
}

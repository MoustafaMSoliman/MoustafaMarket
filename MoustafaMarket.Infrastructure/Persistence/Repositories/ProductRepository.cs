using Microsoft.EntityFrameworkCore;
using MoustafaMarket.Application.Persistence;
using MoustafaMarket.Domain.Common.Errors;
using MoustafaMarket.Domain.ProductAggregate;

namespace MoustafaMarket.Infrastructure.Persistence.Repositories;

public class ProductRepository : IProductRepository
{
    private MarketDbContext _marketDbContext;
    public ProductRepository(MarketDbContext marketDbContext)
    {
        _marketDbContext = marketDbContext;
    }
    public async Task<int> AddAsync(Product item)
    {
        _marketDbContext.Products.Add(item);
        return await _marketDbContext.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        var product = _marketDbContext.Products.FirstOrDefault(p => p.Id.Value == id);
        _marketDbContext.Products.Remove(product);
        return await _marketDbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _marketDbContext.Products.AsNoTracking().ToListAsync();
    }

    public async Task<Product> GetById(Guid id)
    {
        return await _marketDbContext.Products.FirstOrDefaultAsync(p => p.Id.Value == id);
    }

    //public async Task<IEnumerable<Product>> GetByNameAsync(string name)
    //{
    //    return await _marketDbContext.Products.FindAsync(p => p.Name == name).To;
   // }

    public async Task<int> UpdateAsync(Product item)
    {
        _marketDbContext.Products.Update(item);
        return await _marketDbContext.SaveChangesAsync();
    }
}

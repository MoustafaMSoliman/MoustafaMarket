using Microsoft.EntityFrameworkCore;
using MoustafaMarket.Application.Persistence;
using MoustafaMarket.Domain.CategoryAggregate;

namespace MoustafaMarket.Infrastructure.Persistence.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly MarketDbContext _context;
    public CategoryRepository(MarketDbContext context)
    {
        _context = context;
    }
    public async Task<int> AddAsync(Category item)
    {
        _context.Categories.Add(item);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(Guid id)
    {
        _context.Categories.Remove(_context.Categories.FirstOrDefault(c => c.Id.Value == id));
        return await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        return await _context.Categories.AsNoTracking().ToListAsync(); 
    }

    public async Task<Category> GetById(Guid id)
    {
        return await _context.Categories.FirstOrDefaultAsync(c=>c.Id.Value==id);
    }

    public async Task<int> UpdateAsync(Category item)
    {
        _context.Categories.Update(item);
        return await _context.SaveChangesAsync();
    }
}

using Microsoft.EntityFrameworkCore;
using MoustafaMarket.Domain.ProductAggregate;
using MoustafaMarket.Domain.CategoryAggregate;

namespace MoustafaMarket.Infrastructure.Persistence;

public  class MarketDbContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;
    public MarketDbContext()
    {
        
    }
    public MarketDbContext(DbContextOptions<MarketDbContext> options)
        :base(options)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        if (!optionsBuilder.IsConfigured) { 
          optionsBuilder.UseSqlServer("Server=localhost").AddInterceptors(new SlowQueryInterceptor());
        }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MarketDbContext).Assembly);
    }
}

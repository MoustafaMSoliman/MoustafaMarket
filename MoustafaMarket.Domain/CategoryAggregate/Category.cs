using MoustafaMarket.Domain.CategoryAggregate.ValueObjects;
using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.ProductAggregate;

namespace MoustafaMarket.Domain.CategoryAggregate;

public class Category : AggregateRoot<CategoryId>
{
    public string Name { get; } = null!;
    public string Description { get; } = null!;
    private readonly List<Product> _products = new();
    public IReadOnlyList<Product> Products=> _products.AsReadOnly();

#pragma warning disable CS8618
    private Category() { }
#pragma warning restore CS8618
}

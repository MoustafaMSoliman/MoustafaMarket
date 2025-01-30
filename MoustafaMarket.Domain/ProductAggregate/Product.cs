using MoustafaMarket.Domain.CategoryAggregate;
using MoustafaMarket.Domain.CategoryAggregate.ValueObjects;
using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;

namespace MoustafaMarket.Domain.ProductAggregate;

public class Product : AggregateRoot<ProductId>
{
    public string Name { get;} = null!;
    public string Description { get;} = null!;
    public decimal Price { get;}
    public string? Image { get;}
    public int Quantity { get;}
    public CategoryId CategoryId { get; } = null!;
    public Category Category { get; } = null!;

#pragma warning disable CS8618
    private Product() { }
#pragma warning restore CS8618
    private Product(ProductId productId):base(productId) { }

}

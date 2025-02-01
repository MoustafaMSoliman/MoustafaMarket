using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.ProductAggregate.Entities;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;

namespace MoustafaMarket.Domain.ProductAggregate;

public class Product : AggregateRoot<ProductId>
{
    public string Name { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    public Money Price { get; private set; }

    private List<Review> _reviews = new List<Review>();
    public IReadOnlyList<Review> Reviews => _reviews.AsReadOnly();

    public Dimensions Dimensions { get; private set; } = null!;
    public string[]? Images { get; private set; }
    public int Quantity { get; private set; }
    public Category Category { get; private set; } = null!;

#pragma warning disable CS8618
    private Product() { }
#pragma warning restore CS8618
    private Product(ProductId productId, string name, string description, Money price, Dimensions dimensions, string[]? images)
        :base(productId) 
    {
        Name = name;
        Description = description;
        Price = price;
        Dimensions = dimensions;
        Images = images;
    }
    public static Product Create(ProductId productId, string name, string description, Money price, Dimensions dimensions, string[]? images)
        => new(productId, name, description, price,dimensions, images);

    
}

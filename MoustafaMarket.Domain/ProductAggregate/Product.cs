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
    public string? Image { get; private set; }
    public int Quantity { get; private set; }
    public Category Category { get; private set; } = null!;

#pragma warning disable CS8618
    private Product() { }
#pragma warning restore CS8618
    private Product(ProductId productId, string name, string description, Money price, Dimensions dimensions, string image)
        :base(productId) 
    {
        Name = name;
        Description = description;
        Price = price;
        Dimensions = dimensions;
        Image = image;
    }


}

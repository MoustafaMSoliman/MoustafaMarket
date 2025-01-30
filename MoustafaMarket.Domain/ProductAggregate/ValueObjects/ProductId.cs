using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.ProductAggregate.ValueObjects;

public class ProductId : ValueObject
{
    public Guid Value { get; }

#pragma warning disable CS8618
    private ProductId() { }
#pragma warning restore CS8618
    private ProductId(Guid value)
    {
        Value = value;
    }
    public ProductId CreateUnique()=>new(Guid.NewGuid());

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

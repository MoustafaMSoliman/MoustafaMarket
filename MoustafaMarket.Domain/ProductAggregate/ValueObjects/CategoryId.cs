using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.ProductAggregate.ValueObjects;

public class CategoryId : ValueObject
{
    public Guid Value { get; private set; }
#pragma warning disable CS8618
    private CategoryId() { }
#pragma warning restore CS8618
    private CategoryId(Guid value) { Value = value; }
    public static CategoryId CreateUnique()
        =>new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}

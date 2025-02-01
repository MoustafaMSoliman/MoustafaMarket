using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.ProductAggregate.ValueObjects;

public class ReviewId : ValueObject
{
    public Guid Value { get; private set; }
#pragma warning disable CS8618
    private ReviewId() { }
#pragma warning restore CS8618
    private ReviewId(Guid value) 
    {
        Value = value;
    }
    public static ReviewId CreateUnique()
        =>new (Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}

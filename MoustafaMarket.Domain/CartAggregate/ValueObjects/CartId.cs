using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.CartAggregate.ValueObjects;

public class CartId : ValueObject
{
    public Guid Value { get; private set; }

#pragma warning disable CS8618
    private CartId() { }
#pragma warning restore CS8618
    private CartId(Guid value) { Value = value; }
    public static CartId CreateUnique()
        =>new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}

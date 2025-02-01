
using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.CartAggregate.ValueObjects;

public class CartItemId : ValueObject
{
    public Guid Value { get; private set; }

#pragma warning disable CS8618
    private CartItemId() { }
#pragma warning restore CS8618
    private CartItemId(Guid value) { Value = value; }
    public static CartItemId CreateUnique()
        =>new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}

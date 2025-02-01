using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.OrderAggregate.ValueObjects;

public class OrderItemId : ValueObject
{
    public Guid Value { get; private set; }

#pragma warning disable CS8618
    private OrderItemId() { }
#pragma warning restore CS8618
    private OrderItemId(Guid value) { Value = value; }
    public static OrderItemId CreateUnique() =>new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}

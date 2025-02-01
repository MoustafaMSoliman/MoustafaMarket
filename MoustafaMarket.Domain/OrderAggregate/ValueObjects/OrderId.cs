using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.OrderAggregate.ValueObjects;

public class OrderId : ValueObject
{
    public Guid Value { get; private set; }

#pragma warning disable CS8618
    private OrderId() { }
#pragma warning restore CS8618
    private OrderId(Guid value) { Value = value; }
    public static OrderId CreateUnique ()=>new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}

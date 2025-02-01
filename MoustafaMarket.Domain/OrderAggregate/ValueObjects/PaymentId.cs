using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.OrderAggregate.ValueObjects;

public class PaymentId : ValueObject
{
    public Guid Value { get; private set; }
#pragma warning disable CS8618
    private PaymentId() { }
#pragma warning restore CS8618
    private PaymentId(Guid value) { Value = value; }
    public static PaymentId CreateUnique() => new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

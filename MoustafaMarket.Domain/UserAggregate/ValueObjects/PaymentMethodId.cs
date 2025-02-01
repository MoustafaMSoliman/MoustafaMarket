using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.UserAggregate.ValueObjects;

public class PaymentMethodId : ValueObject
{
    public Guid Value { get; private set; }

#pragma warning disable CS8618
    private PaymentMethodId() { }
#pragma warning restore CS8618
    private PaymentMethodId(Guid value) { Value = value; }

    public static PaymentMethodId CreateUnique()
        =>new(Guid.NewGuid());

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

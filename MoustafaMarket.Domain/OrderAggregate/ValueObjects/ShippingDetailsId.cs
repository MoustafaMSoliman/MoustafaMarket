using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.OrderAggregate.ValueObjects;

public class ShippingDetailsId : ValueObject
{
    public Guid Value { get; private set; }
#pragma warning disable CS8618
    private ShippingDetailsId() { }
#pragma warning restore CS8618
    private ShippingDetailsId(Guid value) { Value = value; }
    public static ShippingDetailsId CreateUnique()
        =>new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}

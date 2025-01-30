using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.CustomerAggregate.ValueObjects;

public class CustomerId : ValueObject
{
    public Guid Value { get; private set; }

#pragma warning disable CS8618
    private CustomerId() { }
#pragma warning restore CS8618
    private CustomerId(Guid value)
        { this.Value = value; }
    public static CustomerId CreateUnique()=>new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

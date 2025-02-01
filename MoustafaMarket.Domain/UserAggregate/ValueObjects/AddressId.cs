using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.UserAggregate.ValueObjects;

public class AddressId : ValueObject
{ 
    public Guid Value { get; private set; }
#pragma warning disable CS8618
    private AddressId() { }
#pragma warning restore CS8618
    private AddressId(Guid value) { Value = value; }
    public static AddressId CreateUnique()=>new(Guid.NewGuid());

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

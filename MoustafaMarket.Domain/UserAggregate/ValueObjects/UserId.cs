using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.UserAggregate.ValueObjects;

public class UserId : ValueObject
{
    public Guid Value { get; private set; }
#pragma warning disable CS8618
    private UserId() { }
#pragma warning restore CS8618

    private UserId(Guid value)
    {
        Value = value;
    }
    public static UserId CreateUnique() => new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}

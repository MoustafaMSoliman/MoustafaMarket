using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.InventoryAggregate.ValueObjects;

public class InventoryId : ValueObject
{
    public Guid Value { get; private set; }

#pragma warning disable CS8618
    private InventoryId() { }
#pragma warning restore CS8618
    private InventoryId(Guid value) { Value = value; }
    public static InventoryId CreateUnique()=>new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}

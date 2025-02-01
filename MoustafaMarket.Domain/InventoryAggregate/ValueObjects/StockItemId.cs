using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.InventoryAggregate.ValueObjects;

public class StockItemId : ValueObject
{
    public Guid Value { get; private set; }

#pragma warning disable CS8618
    private StockItemId() { }
#pragma warning restore CS8618
    private StockItemId(Guid value) { Value = value; }
    public static StockItemId CreateUnique() =>new(Guid.NewGuid());
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

}

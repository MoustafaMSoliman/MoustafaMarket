using ErrorOr;
using MoustafaMarket.Domain.Common.Errors;
using MoustafaMarket.Domain.Common.Models;

namespace MoustafaMarket.Domain.InventoryAggregate.ValueObjects;

public class StockLevel : ValueObject
{
    public int Quantity { get; }
#pragma warning disable CS8618
    private StockLevel() { }
#pragma warning restore CS8618
    private StockLevel(int quantity) { Quantity = quantity; }

    public static StockLevel Create(int quantity)=>new(quantity);
    public bool IsAvailable(int requiredQuantity)=> Quantity >= requiredQuantity;
    public ErrorOr<StockLevel> Increase(int quantity)
    {
        if(quantity <= 0)
            return Errors.StockLevelErrors.IncreaseStockLevelWithInvalidQuantity;
        return new StockLevel(Quantity+quantity);

    }
    public ErrorOr<StockLevel> Decrease(int quantity)
    {
        if (this.Quantity - quantity <= 0)
            return Errors.StockLevelErrors.DecreaseStockLevelWithInvalidQuantity;
        return new StockLevel(Quantity-quantity);
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Quantity;
    }

}

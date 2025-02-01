using ErrorOr;
using MoustafaMarket.Domain.Common.Errors;
using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.InventoryAggregate.ValueObjects;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;

namespace MoustafaMarket.Domain.InventoryAggregate.Entities;

public class StockItem : Entity<StockItemId>
{
    public ProductId ProductId { get; }
    public StockLevel StockLevel { get; private set; }

#pragma warning disable CS8618
    private StockItem() { }
#pragma warning restore CS8618
    private StockItem(StockItemId id, ProductId productId, StockLevel stockLevel)
     :base(id)
    {
        ProductId = productId;
        StockLevel = stockLevel;
    }
    public static StockItem Create(StockItemId id, ProductId productId, StockLevel stockLevel)
        => new(id, productId,stockLevel);
    public ErrorOr<Success> IncreaseStock(int quantity)
    {
        if(quantity <= 0)
            return Errors.StockItemErrors.IncreaseStockWithInvalidQuantity;
        StockLevel.Increase(quantity);
        return Result.Success;
        
    }
    public ErrorOr<Success> DecreaseStock(int quantity)
    {
        if ((StockLevel.Quantity - quantity) <= 0)
            return Errors.StockItemErrors.DecreaseStockWithInvalidQuantity;
        else
            StockLevel.Decrease(quantity);
        return Result.Success;

    }
    public bool IsAvailable(int requiredQuantity)
        =>StockLevel.IsAvailable(requiredQuantity);

}

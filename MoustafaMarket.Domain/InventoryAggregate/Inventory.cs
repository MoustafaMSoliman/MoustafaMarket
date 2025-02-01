using ErrorOr;
using MoustafaMarket.Domain.Common.Errors;
using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.InventoryAggregate.Entities;
using MoustafaMarket.Domain.InventoryAggregate.ValueObjects;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;

namespace MoustafaMarket.Domain.InventoryAggregate;

public class Inventory : AggregateRoot<InventoryId>
{
    private readonly List<StockItem> _stockItems = new List<StockItem>();
    public IReadOnlyList<StockItem> StockItems => _stockItems.AsReadOnly();

#pragma warning disable CS8618
    private Inventory() { }
#pragma warning restore CS8618
    private Inventory(InventoryId id):base(id) { }

    public static Inventory Create(InventoryId id) => new(id);
    public ErrorOr<Success> AddStock(ProductId productId, int quantity)
    {
        if (quantity <= 0)
            return Errors.InventoryErrors.AddStockWithInvalidQuantity;
        var existingStock = _stockItems.FirstOrDefault(s=>s.ProductId == productId);
        if (existingStock is not null)
            existingStock.IncreaseStock(quantity);
        else
            _stockItems.Add(StockItem.Create(StockItemId.CreateUnique(), productId, StockLevel.Create(quantity)));
        return Result.Success;
    }
    public ErrorOr<Success> RemoveStock(ProductId productId, int quantity)
    {
        var stock = _stockItems.FirstOrDefault(s=>s.ProductId ==productId);
        if (stock is null)
            return Errors.InventoryErrors.RemoveNotExistStock;

        if (stock.StockLevel.Quantity - quantity <= 0)
            return Errors.InventoryErrors.RemoveStockWithInvalidQuantity;
        stock.DecreaseStock(quantity);
        return Result.Success;
    }
    public bool IsProductAvailable(ProductId productId, int requiredQuantity)
    {
        var stockItem = _stockItems.FirstOrDefault(s=>s.ProductId==productId);
        return stockItem?.IsAvailable(requiredQuantity) ?? false;
    }

}

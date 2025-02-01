using ErrorOr;
using MoustafaMarket.Domain.CartAggregate.Entities;
using MoustafaMarket.Domain.CartAggregate.ValueObjects;
using MoustafaMarket.Domain.Common.Errors;
using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;
using MoustafaMarket.Domain.UserAggregate.ValueObjects;

namespace MoustafaMarket.Domain.CartAggregate;

public class Cart :AggregateRoot<CartId>
{
    private List<CartItem> _items = new List<CartItem>();

    public IReadOnlyList<CartItem> Items => _items.AsReadOnly();
    public UserId UserId { get;}
    public DateTime LastUpdated { get; private set; }

#pragma warning disable CS8618
    private Cart() { }
#pragma warning restore CS8618
    private Cart(CartId id, UserId userId)
     :base(id)
    {
        UserId = userId;
        LastUpdated = DateTime.UtcNow;
    }

    public static Cart Create(CartId id, UserId userId)
        =>new(id, userId);

    private void UpdateTimesTamp()
    {
        LastUpdated = DateTime.UtcNow;
    }
    public ErrorOr<Success> AddItem(ProductId productId, int quantity, decimal unitPrice)
    {
        if (quantity == 0)
            return Errors.CartErrors.AddItemWithZeroQuantity;
        else if (quantity < 0)
            return Errors.CartErrors.AddItemWithQuantityLessThanZero;
        var existingItem = _items.FirstOrDefault(x => x.ProductId == productId);
        if (existingItem is not null)
            existingItem.IncreaseQuantity(quantity);
        else
            _items.Add(CartItem.Create(CartItemId.CreateUnique(),productId, quantity, unitPrice));
        UpdateTimesTamp();
        return Result.Success;
    }
    public ErrorOr<Success> RemoveItem(CartItemId cartItemId)
    {
        var item = _items.FirstOrDefault(i=>i.Id == cartItemId);
        if(item is null)
            return Errors.CartErrors.RemoveNotExistingItem;
        _items.Remove(item);
        UpdateTimesTamp();
        return Result.Success;
    }
    public void ClearCart()=>_items.Clear();
}

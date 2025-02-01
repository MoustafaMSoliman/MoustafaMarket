using ErrorOr;
using MoustafaMarket.Domain.CartAggregate.ValueObjects;
using MoustafaMarket.Domain.Common.Errors;
using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;

namespace MoustafaMarket.Domain.CartAggregate.Entities;

public class CartItem : Entity<CartItemId>
{
    public ProductId ProductId { get; }
    public int Quantity { get; private set; }
    public decimal UnitPrice { get; }

#pragma warning disable CS8618
    private CartItem() { }
#pragma warning restore CS8618
    private CartItem(CartItemId id, ProductId productId, int quantity, decimal unitPrice)
     :base(id)  
    {
        ProductId = productId;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
    public static CartItem Create(CartItemId id, ProductId productId, int quantity, decimal unitPrice)
        => new(id,productId,quantity,unitPrice);
    public ErrorOr<Success> IncreaseQuantity(int  quantity)
    {
        if (quantity == 0)
            return Errors.CartItemErrors.IncreaseZeroQuantity;
        else if (quantity < 0)
            return Errors.CartItemErrors.IncreaseByMinus;
        Quantity += quantity;
        return Result.Success;
    }
    public ErrorOr<Success> DecreaseQuantity(int quantity) 
    {
        if (quantity < 0)
            return Errors.CartItemErrors.DecreaseQuantityFromZero;
        else if (this.Quantity - quantity < 0)
            return Errors.CartItemErrors.DecreaseQuantityBelowToZero;
        Quantity -= quantity;
        return Result.Success;
    }
}

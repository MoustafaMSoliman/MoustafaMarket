using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.OrderAggregate.ValueObjects;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;
using MoustafaMarket.Domain.ProductAggregate;

namespace MoustafaMarket.Domain.OrderAggregate.Entities;

public class OrderItem :Entity<OrderItemId>
{
    public Product Product { get; private set; } // Product associated with the order item
    public int Quantity { get; private set; } // Quantity of the product ordered
    public Money TotalPrice { get; private set; } // Total price of the order item (price * quantity)
#pragma warning disable CS8618
    private OrderItem() { }
#pragma warning restore CS8618
    private OrderItem(OrderItemId id, Product product, int quantity)
      :base(id)
    {
        Product = product;
        Quantity = quantity;
        TotalPrice = product.Price.Multiply(quantity);
    }
    public static OrderItem Create(OrderItemId id, Product product, int quantity)
        =>new(id, product, quantity);   

}

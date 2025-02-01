using MoustafaMarket.Domain.Common.Enums;
using MoustafaMarket.Domain.Common.Models;
using MoustafaMarket.Domain.CustomerAggregate.ValueObjects;
using MoustafaMarket.Domain.OrderAggregate.Entities;
using MoustafaMarket.Domain.OrderAggregate.ValueObjects;
using MoustafaMarket.Domain.ProductAggregate.ValueObjects;
using System.Security.Cryptography.X509Certificates;

namespace MoustafaMarket.Domain.OrderAggregate;

public class Order : AggregateRoot<OrderId>
{
    public CustomerId CustomerId { get; private set; } // The customer who placed the order
    private List<OrderItem> _orderItems = new List<OrderItem>(); // The items in the order
    public IReadOnlyList<OrderItem> OrderItems => _orderItems.AsReadOnly();
    public Money TotalPrice { get; private set; } // The total price of the order
    public ShippingDetails ShippingDetails { get; private set; } // Shipping address for the order
    public Payment Payment { get; private set; } // Payment details
    public OrderStatus Status { get; private set; } // Status of the order

#pragma warning disable CS8618
    private Order() { }
#pragma warning restore CS8618
    private Order(OrderId id, CustomerId customerId)
     : base(id)
    {
        CustomerId = customerId;
        Status = OrderStatus.Pending;

    }
    public static Order Create(OrderId id, CustomerId customerId)
        =>new(id, customerId);
    public void AddOrderItem(OrderItem item)
        =>this._orderItems.Add(item);
    public void RemoveOrderItem(OrderItem item)
        =>this._orderItems.Remove(item);
    public void SetShippingDetails(ShippingDetails shippingDetails)
        =>this.ShippingDetails = shippingDetails;
    public void ShipOrder(string trackingNumber, string carrier)
    {
        this.ShippingDetails.MarkAsShipped(trackingNumber, carrier);
        this.Status = OrderStatus.Shipped;

    }
}

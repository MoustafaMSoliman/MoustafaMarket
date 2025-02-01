using MoustafaMarket.Contracts.Authentication;

namespace MoustafaMarket.Contracts.Order;

public record CreateOrderResponse
(
    string OrderId,
    string UserId,
    OrderItem[] OrderItems,
    decimal TotalPrice,
    decimal? DiscountApplied,
    Address ShippingAddress,
    OrderStatus OrderStatus
);
public record OrderItem
(
  string ProductId,
  string ProductName,
  int Quantity,
  decimal UnitPrice,
  decimal TotalPrice
);
public enum OrderStatus
{
    Pending,
    Shipped,
    Delivered,
    Cancelled
}

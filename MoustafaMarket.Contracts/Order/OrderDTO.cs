using MoustafaMarket.Contracts.Order.Entities;

namespace MoustafaMarket.Contracts.Order;

public record OrderDTO
(
    string Id,
    string UserId,
    decimal TotalAmount,
    DateTime OrderDate,
    List<OrderItemDTO> OrderItems
    );

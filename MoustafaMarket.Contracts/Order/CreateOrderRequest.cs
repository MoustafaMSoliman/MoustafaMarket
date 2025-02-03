using MoustafaMarket.Contracts.Authentication;
using MoustafaMarket.Contracts.Cart;
using MoustafaMarket.Contracts.Order.Entities;

namespace MoustafaMarket.Contracts.Order;

public record CreateOrderRequest
(
    List<OrderItemDTO> OderItems
);
